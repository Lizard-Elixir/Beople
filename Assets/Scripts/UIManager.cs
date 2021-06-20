using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityAtoms.BaseAtoms;

public class UIManager : MonoBehaviour
{

	[SerializeField] private FloatVariable Timer;
	[SerializeField] GameObjectValueList RecruitedBeople;
	[SerializeField] TextMeshProUGUI beopleText;
	[SerializeField] TextMeshProUGUI timerText;

	// Update is called once per frame
	void Update()
	{
		if (Timer.Value <= 0)
		{
			SceneManager.LoadScene("Lose Menu");
		}
		else
		{
			timerText.text = Timer.Value.ToString();
			beopleText.text = "Beople: " + RecruitedBeople.Count.ToString();
		}
	}
}
