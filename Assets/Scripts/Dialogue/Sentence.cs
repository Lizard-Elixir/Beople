using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sentence
{
	public bool isPlayer = false;
	public Sprite portrait;

	[TextArea(3, 10)]
	public string message;
}
