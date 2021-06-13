using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
	public static bool gameIsPaused;

	public GameObject PauseGraphics;
	private AudioThemeManager audioThemeManager;

	void Start()
	{
		PauseGraphics.SetActive(false);
		audioThemeManager = FindObjectOfType<AudioThemeManager>();
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
		audioThemeManager.PauseTheme();
	}

	public void ResumeGame()
	{
		gameIsPaused = false;
		Time.timeScale = 1;
		PauseGraphics.SetActive(false);
		audioThemeManager.ResumeTheme();
	}

	public void QuitGame()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}