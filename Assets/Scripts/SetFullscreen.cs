using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SetFullscreen : MonoBehaviour
{
	[SerializeField] public GameObject toggle;
	private Toggle actualToggle;

	void Start()
	{
		actualToggle = toggle.GetComponent<Toggle>();
		actualToggle.value = Screen.fullScreen;
	}

	public void SetValue(bool fullscreen)
	{
		Screen.fullScreen = fullscreen;
	}
}
