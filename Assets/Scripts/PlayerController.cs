using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float SquawkRadius = 12.5f;
	public float SquawkCooldown = 2f;
	public bool Talking = false;

	private GameObject SquawkGfx;
	private float LastSquawkTime;
	[SerializeField] private VarObject recruitedBeopleVar;

	// Start is called before the first frame update
	void Start()
	{
		SquawkGfx = GameObject.Find("Squawk");
		SetSquawkRadius(SquawkRadius);
		SquawkGfx.SetActive(false);
	}

	void SetSquawkRadius(float radius)
	{
		SquawkGfx.transform.localScale = new Vector3(SquawkRadius * 2, SquawkGfx.transform.localScale.y, SquawkRadius * 2);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButton("Fire1") && !Talking)
		{
			Squawk();
		}

		if (Time.time - LastSquawkTime > SquawkCooldown)
		{
			SquawkGfx.SetActive(false);
		}
	}

	/**
	 * Checks within a radius for recruitable NPCs.
	 * Then, calls a `.Recruit()` method on each of them and adds to them to the beeple recruited count. 
	 */
	void Squawk()
	{
		if (Time.time - LastSquawkTime < SquawkCooldown)
		{
			return;
		}

		SquawkGfx.SetActive(true);

		GameObject[] beople = GameObject.FindGameObjectsWithTag("Berson");
		foreach (GameObject berson in beople)
		{
			float distance = Vector3.Distance(transform.position, berson.transform.position);
			if (distance <= SquawkRadius)
			{
				bool recruited = berson.GetComponent<BirdController>().Recruit();
				if (recruited)
				{
					HandleRecruitment(berson);
				}
			}
		}

		LastSquawkTime = Time.time;
	}

	void HandleRecruitment(GameObject berson)
	{
		switch (berson.name)
		{
			case "ChickenLeader":
				recruitedBeopleVar.currentNum += 10;
				break;
			case "SparrowLeader":
				ThirdPersonMovement movementScript = GetComponentInParent<ThirdPersonMovement>();
				movementScript.speed *= 2f;
				break;
			case "MagpieLeader":
				SetSquawkRadius(SquawkRadius *= 1.5f);
				break;
		}
	}

	public void SetTalking(bool isTalkingNow)
	{
		Talking = isTalkingNow;
	}
}
