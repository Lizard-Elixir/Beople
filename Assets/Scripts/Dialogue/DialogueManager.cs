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
	private Image leftPortrait;
	private Image rightPortrait;
	private AudioThemeManager audioThemeManager;
	private PlayerController playerController;
	public BirdLeaderController birdTarget;

	void Awake()
	{
		HideDialogue();
	}

	void Start()
	{
		sentences = new Queue<Sentence>();
		playerController = FindObjectOfType<PlayerController>();
		audioThemeManager = FindObjectOfType<AudioThemeManager>();
	}

	void Update()
	{
		if (!!birdTarget && Input.GetKeyDown(KeyCode.Space))
		{
			DisplayNextSentence();
		}
	}

	public void StartDialogue(Dialogue dialogue, BirdLeaderController birdLeader)
	{
		Debug.Log("starting conversation with " + dialogue.name);

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

		audioThemeManager.PlayConversationTheme(birdLeader.name);
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

		if (sentence.isPlayer)
		{
			leftPortrait.enabled = true;
			rightPortrait.enabled = false;
			leftPortrait.sprite = sentence.portrait;
		}
		else
		{
			leftPortrait.enabled = false;
			rightPortrait.enabled = true;
			rightPortrait.sprite = sentence.portrait;

		}
	}

	void EndDialogue()
	{
		birdTarget.Recruit();
		audioThemeManager.PlayMainTheme();
		HideDialogue();
		playerController.SetTalking(false);
		birdTarget = null;
	}

	void ShowDialoague()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(true);
		}


		dialogueMessage = GameObject.FindWithTag("DialogueMessage").GetComponent<TextMeshProUGUI>();
		dialogueName = GameObject.FindWithTag("DialogueName").GetComponent<TextMeshProUGUI>();
		leftPortrait = GameObject.Find("LeftPortrait").GetComponent<Image>();
		rightPortrait = GameObject.Find("RightPortrait").GetComponent<Image>();

		dialogueMessage.text = "";
		dialogueName.text = "";
		leftPortrait.sprite = null;
		rightPortrait.sprite = null;
	}

	void HideDialogue()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		}
	}
}
