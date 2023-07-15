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
        int hourNow = time.Hour;
        int minNow = time.Minute;
        int secNow = time.Second;    

        float hXAngle = hourNow * 30f - 90f;
        if (hXAngle < 0) hXAngle += 360;
        hour.transform.eulerAngles = new Vector3(hXAngle, 0, 0);

        float mXAngle = minNow * 6f - 90f;
        if (mXAngle < 0) mXAngle += 360;
        min.transform.eulerAngles = new Vector3(mXAngle, 0, 0);

        float sXAngle = secNow * 6f - 90f;
        if (sXAngle < 0) sXAngle += 360;
        sec.transform.eulerAngles = new Vector3(sXAngle, 0, 0);
    }
}
