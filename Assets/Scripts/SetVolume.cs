using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
	public AudioMixer mixer;
	public Slider slider;

	void Start()
	{
		slider.value = PlayerPrefs.GetFloat("MainVol", 0.75f);
	}

	public void SetLevel(float sliderValue)
	{
		// https://www.youtube.com/watch?v=xNHSGMKtlv4
		mixer.SetFloat("MainVol", Mathf.Log10(sliderValue) * 20);
		// https://gamedevbeginner.com/the-right-way-to-make-a-volume-slider-in-unity-using-logarithmic-conversion/#playpref
		PlayerPrefs.SetFloat("MainVol", sliderValue);
	}
}
