using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
	public Dialogue currentDialogue;

	private Queue<Sentence> sentences;
	private TextMeshProUGUI dialogueName;
	private TextMeshProUGUI dialogueMessage;
	private Image portrait;
	private PlayerController playerController;
	private BirdLeaderController birdTarget;

	void Awake()
	{
		HideDialogue();
	}

	void Start()
	{
		sentences = new Queue<Sentence>();
		playerController = FindObjectOfType<PlayerController>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return)) {
			DisplayNextSentence();   
		}
	}

	public void StartDialogue(Dialogue dialogue, BirdLeaderController birdLeader)
	{
		Debug.Log("starting conversation with" + dialogue.name);

		birdTarget = birdLeader;
		playerController.SetTalking(true);

		currentDialogue = dialogue;

		sentences.Clear();

		foreach (Sentence sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		ShowDialoague();
		DisplayNextSentence();
	}

	void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		Sentence sentence = sentences.Dequeue();

		dialogueName.text = sentence.isPlayer ? "Beepo" : currentDialogue.name;
		dialogueMessage.text = sentence.message;
		portrait.sprite = sentence.portrait;
	}

	void EndDialogue()
	{
		dialogueMessage.text = "";
		dialogueName.text= "";
		portrait.sprite = null;
		HideDialogue();
		playerController.SetTalking(false);
		birdTarget.Recruit();
		birdTarget = null;
	}

	void ShowDialoague()
	{
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(true);
		}

		
		dialogueMessage = GameObject.FindWithTag("DialogueMessage").GetComponent<TextMeshProUGUI>();
		dialogueName = GameObject.FindWithTag("DialogueName").GetComponent<TextMeshProUGUI>();
		portrait = GameObject.FindWithTag("DialoguePortrait").GetComponent<Image>();

		dialogueMessage.text = "";
		dialogueName.text= "";
		portrait.sprite = null;
	}

	void HideDialogue()
	{
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		}
	}
}
