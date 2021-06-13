using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioThemeManager : MonoBehaviour
{
	private AudioSource theme;

	[SerializeField] public BirdLeaderController chickenLeader;
	[SerializeField] public BirdLeaderController magpieLeader;
	[SerializeField] public BirdLeaderController sparrowLeader;

	public AudioClip NPCChickenLoop;
	public AudioClip NPCMagpieLoop;
	public AudioClip NPCSparrowLoop;

	public AudioClip ThemeBeepoOnly;

	public AudioClip ThemeBeepoChicken;
	public AudioClip ThemeBeepoChickenMagpie;
	public AudioClip ThemeBeepoChickenSparrow;

	public AudioClip ThemeBeepoMagpie;
	public AudioClip ThemeBeepoMagpieSparrow;

	public AudioClip ThemeBeepoSparrow;

	public AudioClip ThemeAll;

	void Start()
	{
		theme = GetComponent<AudioSource>();
		theme.loop = true;
		theme.Stop();

		PlayMainTheme();
	}

	public void PlayConversationTheme(string birdName) {
		switch (birdName)
		{
			case "ChickenLeader":
				theme.clip = NPCChickenLoop;
				theme.Play();
				break;
			case "SparrowLeader":
				theme.clip = NPCSparrowLoop;
				theme.Play();
				break;
			case "MagpieLeader":
				theme.clip = NPCMagpieLoop;
				theme.Play();
				break;
			default:
				theme.clip = null;
				theme.Stop();
				break;
		}
	}

	public void PlayMainTheme() {
		bool chickenRecruited = chickenLeader.IsRecruited;
		bool magpieRecruited = magpieLeader.IsRecruited;
		bool sparrowRecruited = sparrowLeader.IsRecruited;

		theme.clip = ThemeBeepoOnly;

		if (chickenRecruited) {
			if (magpieRecruited) {
				if (sparrowRecruited) {
					theme.clip = ThemeAll;
				} else {
					theme.clip = ThemeBeepoChickenMagpie;
				}
			} else if (sparrowRecruited) {
				theme.clip = ThemeBeepoChickenSparrow;
			} else {
				theme.clip = ThemeBeepoChicken;
			}
		} else if (magpieRecruited) {
			if (sparrowRecruited) {
				theme.clip = ThemeBeepoMagpieSparrow;
			} else {
				theme.clip = ThemeBeepoMagpie;
			}
		} else if (sparrowRecruited) {
			theme.clip = ThemeBeepoSparrow;
		}

		theme.Play();
	}

	public void PauseTheme() {
		theme.Pause();
	}

	public void ResumeTheme() {
		theme.Play();
	}
}
