using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
