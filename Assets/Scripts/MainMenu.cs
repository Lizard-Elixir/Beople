using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject IntroExposition;

	public void Start()
	{
		IntroExposition.SetActive(false);
	}

	public void ShowIntroExposition()
	{
		IntroExposition.SetActive(true);
	}

	public void PlayGame()
	{
		SceneManager.LoadScene("Main");
	}

	public void QuitGame()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
