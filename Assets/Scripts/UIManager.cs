using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

	[SerializeField] VarNumber timer;
	[SerializeField] VarNumber beopleCounter;
	[SerializeField] TextMeshProUGUI beopleText;
	[SerializeField] TextMeshProUGUI timerText;

	// Update is called once per frame
	void Update()
	{
		if (timer.currentNum <= 0)
		{
			SceneManager.LoadScene("Lose Menu");
		}
		else
		{
			timerText.text = timer.currentNum.ToString();
			beopleText.text = "Beople: " + beopleCounter.currentNum.ToString();
		}
	}
}
