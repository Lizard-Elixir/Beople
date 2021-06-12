using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private VarObject recruitedBeopleVar;
    [SerializeField] private VarObject timer;

    // Start is called before the first frame update
    void Start()
    {
        timer.currentNum = timer.startingNum;
        recruitedBeopleVar.currentNum = recruitedBeopleVar.startingNum;
        InvokeRepeating("timerTick", 0,1);
    }

    void timerTick()
    {
        timer.currentNum -= 1;
    }




}
