using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityAtoms.BaseAtoms;

public class GameManager : MonoBehaviour
{
	public PlayerController playerController;
	[SerializeField] StateObject state;
	[SerializeField] private BoolVariable PlayerIsTalking;

	// Start is called before the first frame update
	void Start()
	{
		state.timer.currentNum = state.timer.startingNum;
		InvokeRepeating("timerTick", 0, 1);
	}

	void timerTick()
	{
		if (PlayerIsTalking.Value)
		{
			return;
		}

		state.timer.currentNum -= 1;
		if (state.timer.currentNum <= 0)
		{
			SceneManager.LoadScene("Lose Menu");
		}
	}
}
