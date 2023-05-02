using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScore : MonoBehaviour
{
    public void ClearScoreBoard()
    {
        string path = "Assets/scores.txt";
        System.IO.File.WriteAllText(path, String.Empty);
    }
}
