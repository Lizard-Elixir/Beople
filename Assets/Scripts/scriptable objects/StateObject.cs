using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateController")]
public class StateObject : ScriptableObject
{
	public TimerState timer = new TimerState();
}

[System.Serializable]
public class TimerState
{
	public float startingNum = 210;
	public float currentNum = 210;
}
