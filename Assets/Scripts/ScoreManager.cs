using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    public static int value = 0;


    private void FixedUpdate()
    {
        _scoreText.text = "Score:" + ProgressBarController.value.ToString("D3");
    }
}
