using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Kello2 : MonoBehaviour 
{  
    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

     void Start()
    {
    }
	void Update () 

    {
		hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * DateTime.Now.Hour); 
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * DateTime.Now.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * DateTime.Now.Second);      
	}
    }

