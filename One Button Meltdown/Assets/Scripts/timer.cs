using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    float time_secs = 300;
    public string timerText;

	// Use this for initialization
	void Start () {
        StartCountdownTimer();
        print(timerText);

    }

    void StartCountdownTimer()
    {
        if (timerText != null)
        {
            timerText = "";
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

            timerText = "Time Left: " + mins + ":" + secs + ":" + frac;
        }
    }
}
