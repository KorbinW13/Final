using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPoints : MonoBehaviour
{
    public Text PointsText;
    public static int Points = 0;


    // Start is called before the first frame update
    void Start()
    {
        PointsText.text = Points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PointsText.text = Points.ToString();
    }

    public void IncreaseButton() { Points++; }
    public void DecreaseButton() { Points--; }
}
