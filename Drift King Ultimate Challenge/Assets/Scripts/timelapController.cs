using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timelapController : MonoBehaviour
{

    private float InGameTime = 0f;
    private int lapCount = 0;
    public TMP_Text timeText;
    public TMP_Text lapText;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayLap();
        DisplayTime(InGameTime);
        if (lapCount > 2)
        {
            DisplayTime(InGameTime);
        }
        else
        {
            InGameTime += Time.deltaTime;
            DisplayTime(InGameTime);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        lapCount += 1;
    }
    
    void DisplayTime(float TimeToDisplay)
    {
        float min = Mathf.FloorToInt(TimeToDisplay / 60);
        float sec = Mathf.FloorToInt(TimeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
    
    private void displayLap()
    {
        lapText.text = String.Format("{0}", lapCount);
    }

    
}
