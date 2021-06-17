using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

	[SerializeField] VarNumber timer;
	[SerializeField] TextMeshProUGUI beopleText;
	[SerializeField] TextMeshProUGUI timerText;
	private HashSet<GameObject> RecruitedBeople;

	void Start()
	{
		RecruitedBeople = GameObject.FindWithTag("Player").GetComponent<PlayerController>().RecruitedBeople;
	}

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
			beopleText.text = "Beople: " + RecruitedBeople.Count.ToString();
		}
	}
}
