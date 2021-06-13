using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameStats : MonoBehaviour
{

	[SerializeField] VarObject timer;
	[SerializeField] VarObject beopleCounter;
	[SerializeField] TextMeshProUGUI statsText;

	// Update is called once per frame
	void Update()
	{
		statsText.text = beopleCounter.currentNum.ToString() + " beople saved with " + timer.currentNum.ToString() + " seconds remaining";
	}
}
