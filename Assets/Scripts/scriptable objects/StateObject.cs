using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateController")]
public class StateObject : ScriptableObject
{
	public Timer timer = new Timer();
	public HashSet<GameObject> RecruitedBeople = new HashSet<GameObject>();

}

public class Timer
{
	public float startingNum = 240;
	public float currentNum = 240;
}
