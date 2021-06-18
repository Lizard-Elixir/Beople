using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public bool Talking = false;

	public HashSet<GameObject> RecruitedBeople = new HashSet<GameObject>();
	private PauseControl pauseControl;
	private SquawkController squawkController;

	// Start is called before the first frame update
	void Start()
	{
		pauseControl = FindObjectOfType<PauseControl>();
		squawkController = FindObjectOfType<SquawkController>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !Talking && !pauseControl.gameIsPaused)
		{
			squawkController.Squawk();
		}
	}

	public void SetTalking(bool isTalkingNow)
	{
		Talking = isTalkingNow;
	}

}
