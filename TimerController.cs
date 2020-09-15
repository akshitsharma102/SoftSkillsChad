using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public int time;
    public Text TimerText;


    private void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while (time > 0)
        {
            TimerText.text = time.ToString();
            yield return new WaitForSeconds(1f);
            time--;
        }
    }
}
