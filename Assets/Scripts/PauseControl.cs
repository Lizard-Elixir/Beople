using UnityEngine;
using UnityEngine.SceneManagement;
using UnityAtoms.BaseAtoms;

public class PauseControl : MonoBehaviour
{
	public GameObject PauseGraphics;
	[SerializeField] private BoolVariable Paused;
	private AudioThemeManager audioThemeManager;

	void Start()
	{
		PauseGraphics.SetActive(false);
		audioThemeManager = FindObjectOfType<AudioThemeManager>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && Paused)
		{
			Paused.Value = !Paused.Value;
		}
	}

	public void TogglePause(bool pause)
	{
		if (pause)
		{
			Time.timeScale = 0f;
			PauseGraphics.SetActive(true);
			audioThemeManager.PauseTheme();
			Input.ResetInputAxes();
		}
		else
		{
			Time.timeScale = 1;
			PauseGraphics.SetActive(false);
			audioThemeManager.ResumeTheme();
			Input.ResetInputAxes();
		}
	}

	public void PauseGame()
	{
		Paused.Value = true;
	}

	public void ResumeGame()
	{
		Paused.Value = false;
	}

	public void GoToMainMenu()
	{
		ResumeGame();
		SceneManager.LoadScene("Main Menu");
	}
}