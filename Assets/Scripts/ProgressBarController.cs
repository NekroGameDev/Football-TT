using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController : MonoBehaviour
{
    [SerializeField] private Image image;
    public static int maxValue = 100;

    public static int value = 0;


    private readonly int winValue = 85;
    public static int minValue = 0;

    private void Start()
    {
        value = 0;
    }

    private void LateUpdate()
    {
        image.fillAmount = (float)value / maxValue;
    }

    private void FixedUpdate()
    {
        if(value < minValue)
        {
            Won.valueWon = false;
        }

        if (value >= winValue)
        {
            Won.valueWon = true;
        }
    }


    public void SetMaxValue(int maxValue) => ProgressBarController.maxValue = maxValue;
}
