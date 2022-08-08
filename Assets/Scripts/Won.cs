using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Won : MonoBehaviour
{
    public static bool timeIsOver;
    public static bool valueWon;

    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _cannon;

    private void LateUpdate()
    {
        if(timeIsOver & valueWon)
        {
            _cannon.SetActive(false);
            _player.SetActive(false);
            _winPanel.SetActive(true);
            timeIsOver = false;
            valueWon = false;
        }

        if(timeIsOver & !valueWon)
        {
            _cannon.SetActive(false);
            _player.SetActive(false);
            _losePanel.SetActive(true);
            timeIsOver = false;
            valueWon = false;
        }
    }

}
