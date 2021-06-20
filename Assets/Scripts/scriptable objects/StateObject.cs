using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateController")]
public class StateObject : ScriptableObject
{
	public TimerState timer = new TimerState();
	public PlayerState player = new PlayerState();
}

[System.Serializable]
public class TimerState
{
	public float startingNum = 210;
	public float currentNum = 210;
}

[System.Serializable]
public class PlayerState
{
	public bool isTalking = false;
}
