using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public TextMesh pointsText;
    private int points;

    private void Start()
    {
        InvokeRepeating("pointsInc", 0, 1f);
    }

    void pointsInc()
    {
        if (GameObject.Find("ThirdPersonController") != null)
        {
            points++;
            pointsText.text = "Points: " + points.ToString();
        }
    }
}
