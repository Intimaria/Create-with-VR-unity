using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject hour, min, sec;
    float unit = (float) 7.5;
     
    void Awake()
    {
        hour = GameObject.Find("Clock_Analog_A_Hour");
        min = GameObject.Find("Clock_Analog_A_Minute");
        sec = GameObject.Find("Clock_Analog_A_Second");
    }

    // Update is called once per frame
    void Update()
    {
    DateTime time = DateTime.Now;
    int hourNow = (int)time.Hour;
    int minNow = (int) time.Minute;
    int secNow = (int) time.Second;    
    Debug.Log(hourNow);
    Debug.Log(minNow);
    Debug.Log(secNow);
    float hXAngle = (float) hourNow;
    hour.transform.Rotate(90, 0, -90, Space.Self);
    float mXAngle = (float) minNow;
    min.transform.Rotate(80, 0, -90, Space.Self);
    float sXAngle = (float) secNow;
    sec.transform.Rotate(sXAngle, 0, -90, Space.Self);
    }
}
