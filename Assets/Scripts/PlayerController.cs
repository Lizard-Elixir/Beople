using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float SquawkRadius = 35f;
	public float SquawkCooldown = 2;

	private GameObject SquawkGfx;
	private float LastSquawkTime;

	// Start is called before the first frame update
	void Start()
	{
		SquawkGfx = GameObject.Find("Squawk");
		SquawkGfx.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButton("Fire1"))
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
     * Then, calls a `.Recruit()` method on each of them. 
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
				berson.GetComponent<BirdController>().Recruit();
			}
		}

		LastSquawkTime = Time.time;
	}
}
