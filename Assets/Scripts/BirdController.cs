using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
	private bool IsRecruited = false;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (IsRecruited)
		{

		}
	}

	public void Recruit()
	{
		IsRecruited = true;
	}
}
