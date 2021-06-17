using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public PlayerController playerController;
	[SerializeField] private VarNumber timer;

	// Start is called before the first frame update
	void Start()
	{
		timer.currentNum = timer.startingNum;
		InvokeRepeating("timerTick", 0, 1);
	}

	void timerTick()
	{
		if (playerController.Talking)
		{
			return;
		}

		timer.currentNum -= 1;
		if (timer.currentNum <= 0)
		{
			SceneManager.LoadScene("Lose Menu");
		}
	}
}
