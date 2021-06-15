using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ParkController : MonoBehaviour
{
	Collider parkCollider;
	Vector3 playerPosition;

	private GameObject player;
	private TextMeshPro instructions;
	[SerializeField] VarObject birbCounter;
	public int birbRequirement;

	void Start()
	{
		player = GameObject.FindWithTag("Player");
		parkCollider = GetComponent<Collider>();
		playerPosition = player.transform.position;
		instructions = transform.GetComponentInChildren<TextMeshPro>();
		instructions.text = "";
	}

	void Update()
	{
		Vector3 pointCheck = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
		if (parkCollider.bounds.Contains(pointCheck))
		{
			if (birbCounter.currentNum >= birbRequirement)
			{
				instructions.text = "Press \"E\" to fly away";
			}
			else
			{
				instructions.text = "You need " + birbRequirement.ToString() + " beople before you can fly away!";
			}



			if (Input.GetKeyDown(KeyCode.E) && birbCounter.currentNum >= birbRequirement)
			{
				SceneManager.LoadScene("Win Menu");
			}
		}
		else
		{
			instructions.text = "";
		}
	}
}