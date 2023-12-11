using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TaskTimer : MonoBehaviour
{
    TextMeshProUGUI timerText;
    public float minutes;
    float timer;
    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timer = minutes * 60;
    }
    private void Update()
    {
        timer = Mathf.Max(0, timer - Time.deltaTime);
        var timeSpan = System.TimeSpan.FromSeconds(timer);
        timerText.text = timeSpan.Hours.ToString("00") + ":" +
                        timeSpan.Minutes.ToString("00") + ":" +
                        timeSpan.Seconds.ToString("00");
    }
}

