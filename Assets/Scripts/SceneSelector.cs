using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void StartGame()
    {
        if (InputName.PlayerName.Length == 0)
        {
            InputName.PlayerName = "AAA";
        }
        DisplayPoints.Points = 0;
        SceneManager.LoadScene("2Game");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void ExitScene()
    {
        string name = InputName.PlayerName;
        string score = DisplayPoints.Points.ToString();
        GameObject.Find("GoneButton").GetComponent<WriteScores>().AddNewScore(name, score);
        SceneManager.LoadScene("3Exit");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
