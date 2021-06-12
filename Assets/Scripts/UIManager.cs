using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{

    [SerializeField] VarObject timer;
    [SerializeField] VarObject beopleCounter;
    [SerializeField] TextMeshProUGUI beopleText;
    [SerializeField] TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.currentNum.ToString();
        beopleText.text = "Beople: " + beopleCounter.currentNum.ToString();
    }
}
