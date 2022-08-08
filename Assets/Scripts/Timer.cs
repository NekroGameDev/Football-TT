using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private int sec;
    [SerializeField] private int min;
    [SerializeField] private Text timerText;

    private void Start()
    {
        StartCoroutine(TimeFlow());
    }

    IEnumerator TimeFlow()
    {
        while (true)
        {
            if (sec == 0)
            {
                min--;
                sec += 60;
            }
            sec--;
            timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
    private void FixedUpdate()
    {
        
        int time = sec + min;

        if(time <= 0)
        {
            Won.timeIsOver = true;
            StopAllCoroutines();
        }
        
    }
}
