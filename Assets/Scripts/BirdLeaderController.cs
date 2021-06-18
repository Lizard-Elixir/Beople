using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLeaderController : BirdController
{
	public Dialogue dialogue;
	private SquawkController SquawkController;
	private GameObject SpeechBubble;

	new void Start()
	{
		base.Start();
		SquawkController = player.transform.Find("Squawk").gameObject.GetComponent<SquawkController>();
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
			if (distanceFromPlayer <= SquawkController.SquawkRadius)
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
