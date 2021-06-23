using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetVolume : MonoBehaviour
{
	public AudioMixer mixer;

	public void SetLevel(float sliderValue)
	{
		// https://www.youtube.com/watch?v=xNHSGMKtlv4
		mixer.SetFloat("MainVol", Mathf.Log10(sliderValue) * 20);
	}
}
