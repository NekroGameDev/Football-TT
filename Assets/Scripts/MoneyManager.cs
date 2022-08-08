using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    public static int Money = 50;

    
    private void FixedUpdate()
    {
        _scoreText.text = "Money:" + Money.ToString("D3");
    }

    
}
