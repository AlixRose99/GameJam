using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    float time_secs = 300;
    public Text timerText;


    // Use this for initialization
    void Start () {


        StartCountdownTimer();

    }

    void StartCountdownTimer()
    {
        if (timerText != null)
        {
            timerText.text = "5:00:000";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }
    void UpdateTimer()
    {
        if (timerText != null)
        {
            time_secs -= Time.deltaTime;
            string mins = Mathf.Floor(time_secs / 60).ToString("00");
            string secs = (time_secs % 60).ToString("00");
            string frac = ((time_secs * 100) %100).ToString("000");

            timerText.text = "Time Left: " + mins + ":" + secs + ":" + frac;
        }
    }
}
