using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour
{
    public Text LivesText;
    public static int Lives;


    // Start is called before the first frame update
    void Start()
    {
        Lives = LivesDropdown.Lives;
    }

    // Update is called once per frame
    void Update()
    {
        LivesText.text = Lives.ToString();
    }

    public void IncreaseButton() { Lives++;}
    public void DecreaseButton() { Lives--;}
}
