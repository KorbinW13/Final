using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDropdown : MonoBehaviour
{
    public static int Lives = 1;
    public Dropdown LifeDropdown;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetLives(LifeDropdown);
    }

    public void SetLives(Dropdown sender)
    {
        switch (sender.value)
        {
            case 0:
                Lives = 1;
                Debug.Log("Lives: " + Lives);
                break;
            case 1:
                Lives = 2;
                Debug.Log("Lives: " + Lives);
                break;
            case 2:
                Lives = 3;
                Debug.Log("Lives: " + Lives);
                break;
            case 3:
                Lives = 4;
                Debug.Log("Lives: " + Lives);
                break;
            case 4:
                Lives = 5;
                Debug.Log("Lives: " + Lives);
                break;
            case 5:
                Lives = 6;
                Debug.Log("Lives: " + Lives);
                break;
            case 6:
                Lives = 7;
                Debug.Log("Lives: " + Lives);
                break;
            case 7:
                Lives = 8;
                Debug.Log("Lives: " + Lives);
                break;
            case 8:
                Lives = 9;
                Debug.Log("Lives: " + Lives);
                break;
        }
    }
}
