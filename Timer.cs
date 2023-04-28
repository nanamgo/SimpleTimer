//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    public float current { get; set; } //Current time
    float before; //Brfore time
    float limit; //Limit time

    public Timer()
    {
        current = 0;
        before = 0;
        limit = 0;
    }

    public void SetTimer(float time)
    {
        limit = time;
    }

    public bool Count()
    {
        current = before + Time.deltaTime;
        before = current;
        return (current > limit) ? true : false;
    }

    public void Reset()
    {
        current = 0;
        before = 0;
        limit = 0;
    }
}