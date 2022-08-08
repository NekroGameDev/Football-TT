using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public void OnStart()
    {
        SceneManager.LoadScene("Scenes/Level1");
    }

    public void OnBack()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void OnExit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif 
    }
}
