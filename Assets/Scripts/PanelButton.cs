using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    
}
