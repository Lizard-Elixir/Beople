using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameStats : MonoBehaviour
{

	[SerializeField] StateObject state;
	[SerializeField] TextMeshProUGUI statsText;

	// Update is called once per frame
	void Update()
	{
		int count = state.RecruitedBeople.Count;
		float time = state.timer.currentNum;
		statsText.text = count.ToString() + " beople saved with " + time.ToString() + " seconds remaining";
	}
}
