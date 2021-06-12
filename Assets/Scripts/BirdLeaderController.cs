using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLeaderController : BirdController
{
    public Dialogue dialogue;

    void Update()
    {
        if (!IsRecruited) {
            float dist = Vector3.Distance(player.transform.position, transform.position);

            if (dist < 5 && Input.GetKeyDown(KeyCode.E)) {
                TriggerDialogue();
            }
        }

        else
			MoveTowardsPlayer();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, this);
    }
}
