using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject IntroExposition;
	public GameObject LoadingScreen;

	public void Start()
	{
		IntroExposition.SetActive(false);
		LoadingScreen.SetActive(false);
	}

	public void ShowIntroExposition()
	{
		IntroExposition.SetActive(true);
	}

	public void PlayGame()
	{
		LoadingScreen.SetActive(true);
		IntroExposition.SetActive(false);
		SceneManager.LoadScene("Main");
	}

	public void QuitGame()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}

	public void ShowMainMenu()
	{
		SceneManager.LoadScene("Main Menu");
	}
}
