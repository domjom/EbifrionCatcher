using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int lifeRemaining;

    public Text LifeCount;
    public Text PointCount;

    void Start()
    {
        score = 0;
        lifeRemaining = 5;
    }

    void Update()
    {
        if(score == 30)
        {
            Debug.Log("You Win!");
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("YouWin!");
        }

        if(lifeRemaining == 0)
        {
            Debug.Log("You Lose!");
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("YouLose!");
        }

        LifeCount.text = lifeRemaining.ToString();
        PointCount.text = score.ToString();
    }
}
