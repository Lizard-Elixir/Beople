using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
	CharacterController characterController;
	private GameObject player;

	private bool IsRecruited = false;
	[SerializeField] private float speed = 5.0f;
	[SerializeField] private double playerBufferDistance = 3.0;

	void Awake() => characterController = GetComponent<CharacterController>();

	void Start()
	{
		player = GameObject.FindWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{
		if (IsRecruited)
		{
			MoveTowardsPlayer();
		}
	}

	public void Recruit()
	{
		if (IsRecruited)
		{
			return;
		}

		IsRecruited = true;
		Debug.Log("Recruited Berson!");
	}

	void MoveTowardsPlayer()
	{
		float dist = Vector3.Distance(player.transform.position, transform.position);
		float step = speed * Time.deltaTime;

		if (dist > playerBufferDistance)
		{
			Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
			Vector3 newPos = Vector3.MoveTowards(transform.position, playerPos, step);
			Vector3 moveVector = newPos - transform.position;

			characterController.Move(moveVector);
			transform.LookAt(playerPos);
		}
	}
}
