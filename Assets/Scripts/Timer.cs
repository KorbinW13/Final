using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public static float timer;
    public Text TimerText;


    private void Start()
    {
        timer = TimeSlider.playerTime;
    }
    
    void Update()
    {
        timer -= Time.deltaTime;
        TimerText.text = timer.ToString("F2") + " (seconds) left";

        if (timer < 0f )
        {
            TimerEnded();
        }
    }

    void TimerEnded()
    {
        TimerText.text = "Time Over";
        //SceneManager.LoadScene("3Exit");
    }
}