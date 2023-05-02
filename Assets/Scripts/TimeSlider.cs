using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{
    public Slider mySlider;
    public Text TimeText;
    public static float playerTime = 30f;

    public void Start()
    {
        TimeText.text = "Timer: " + mySlider.value + " secs";
    }
    public void SpeedSlider()
    {
        TimeText.text = "Timer: " + mySlider.value + " secs";
        Debug.Log("Timer: " + mySlider.value + " secs");
        playerTime = mySlider.value;
    }
}
