using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class PlayerController : MonoBehaviour
{
	[SerializeField] StateObject state;
	[SerializeField] private BoolVariable Paused;
	[SerializeField] private BoolVariable PlayerIsTalking;
	private SquawkController squawkController;

	// Start is called before the first frame update
	void Start()
	{
		squawkController = FindObjectOfType<SquawkController>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !PlayerIsTalking.Value && !Paused.Value)
		{
			squawkController.Squawk();
		}
	}

	public void SetTalking(bool isTalkingNow)
	{
		PlayerIsTalking.Value = isTalkingNow;
	}
}
