using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class PlayerController : MonoBehaviour
{
	[SerializeField] StateObject state;
	[SerializeField] private BoolVariable Paused;
	private SquawkController squawkController;

	// Start is called before the first frame update
	void Start()
	{
		squawkController = FindObjectOfType<SquawkController>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !state.player.isTalking && !Paused.Value)
		{
			squawkController.Squawk();
		}
	}

	public void SetTalking(bool isTalkingNow)
	{
		state.player.isTalking = isTalkingNow;
	}
}
