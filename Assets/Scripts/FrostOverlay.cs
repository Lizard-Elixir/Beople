using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

public class FrostOverlay : MonoBehaviour
{
	[Tooltip("Time (in seconds) when the frost graphic should start fading in.")]
	public int frostBeginTime = 45;
	[Tooltip("Time (in seconds) when the frost graphic should fully faded in.")]
	public int frostCompleteTime = 15;
	[SerializeField] private FloatVariable Timer;
	private Image image;

	// Start is called before the first frame update
	void Start()
	{
		image = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update()
	{
		Color tempColor = image.color;
		if (Timer.Value > frostBeginTime)
		{
			tempColor.a = 0;
		}
		else
		{
			tempColor.a = 1 - (Timer.Value - frostCompleteTime) / frostBeginTime;
		}

		image.color = tempColor;
	}
}
