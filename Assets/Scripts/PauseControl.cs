using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
	public static bool gameIsPaused;

	public GameObject PauseGraphics;

	void Start()
	{
		PauseGraphics.SetActive(false);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			TogglePause();
		}
	}

	public void TogglePause()
	{
		if (gameIsPaused)
		{
			ResumeGame();
		}
		else
		{
			PauseGame();
		}
	}

	public void PauseGame()
	{
		gameIsPaused = true;
		Time.timeScale = 0f;
		PauseGraphics.SetActive(true);
	}

	public void ResumeGame()
	{
		gameIsPaused = false;
		Time.timeScale = 1;
		PauseGraphics.SetActive(false);
	}

	public void QuitGame()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}