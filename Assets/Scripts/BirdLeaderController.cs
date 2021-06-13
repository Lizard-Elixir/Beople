using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLeaderController : BirdController
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, this);
    }
}
