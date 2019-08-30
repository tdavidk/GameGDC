using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText;
    int time = 15;
    public GameObject panelGameOver;

	void Start ()
    {
        InvokeRepeating("IncreaseTime", 0f, 1f);	
	}
	
	void IncreaseTime()
    {
        time--;
        timerText.text = "Time = " + time;

        if (time == 0)
        {
            CancelInvoke("IncreaseTime");
            panelGameOver.SetActive(true);
            PointCounter.coinAmount = 3;
        }
    }
}
