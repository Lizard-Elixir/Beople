using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityAtoms.BaseAtoms;

public class EndGameStats : MonoBehaviour
{
	[SerializeField] private FloatVariable Timer;
	[SerializeField] GameObjectValueList RecruitedBeople;
	[SerializeField] TextMeshProUGUI statsText;

	// Update is called once per frame
	void Update()
	{
		int count = RecruitedBeople.Count;
		float time = Timer.Value;
		statsText.text = count.ToString() + " beople saved with " + time.ToString() + " seconds remaining";
	}
}
