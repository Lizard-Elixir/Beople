using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameStats : MonoBehaviour
{

	[SerializeField] VarNumber timer;
	[SerializeField] TextMeshProUGUI statsText;

	private GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{
		int count = player.GetComponent<PlayerController>().RecruitedBeople.Count;
		statsText.text = count.ToString() + " beople saved with " + timer.currentNum.ToString() + " seconds remaining";
	}
}
