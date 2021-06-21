using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class BirdLeaderController : BirdController
{
	public Dialogue dialogue;
	private SquawkController SquawkController;
	private GameObject SpeechBubble;
	[SerializeField] private FloatVariable SquawkRadius;

	new void Start()
	{
		base.Start();
		SpeechBubble = transform.Find("GFX").transform.Find("SpeechBubble").gameObject;
	}

	new void Update()
	{
		base.Update();
		if (IsRecruited)
		{
			HideSpeechBubble();
		}
		else
		{
			float distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);
			if (distanceFromPlayer <= SquawkRadius.Value)
			{
				ShowSpeechBubble();
			}
			else
			{
				HideSpeechBubble();
			}
		}
	}

	private void ShowSpeechBubble()
	{
		SpeechBubble.SetActive(true);
	}

	private void HideSpeechBubble()
	{
		SpeechBubble.SetActive(false);
	}

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue, this);
	}
}
