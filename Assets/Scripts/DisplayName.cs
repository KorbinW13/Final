using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text PlayerNameText;
    public static string playerName;
    void Start()
    {
        playerName = InputName.PlayerName;
        PlayerNameText.text = "Currently playing: " + playerName;
    }
}
