using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityAtoms.BaseAtoms;

public class GameManager : MonoBehaviour
{
	public PlayerController playerController;
	[SerializeField] private FloatVariable Timer;
	[SerializeField] private BoolVariable PlayerIsTalking;

	// Start is called before the first frame update
	void Start()
	{
		Timer.Value = Timer.InitialValue;
		InvokeRepeating("timerTick", 0, 1);
	}

	void timerTick()
	{
		if (PlayerIsTalking.Value)
		{
			return;
		}

		Timer.Value -= 1;
		if (Timer.Value <= 0)
		{
			SceneManager.LoadScene("Lose Menu");
		}
	}
}
