using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    Clock clock;
    WrapClock wrap_clock;
    
    void Start()
    {
        clock = new Clock();
        clock.SetTimer(10f);
        //clock.Reset();

        wrap_clock = new WrapClock();
        wrap_clock.SetTimer(4f);
        //wrap_clock.Reset();

        StaticTimer.SetStaticTimer(5f);
        //StaticTimer.StaticReset();
    }

    void Update()
    {
        //Timer count
        if (!clock.Count())
        {
            Debug.Log("Timer:" + clock.current);
        }
        else
        {
            Debug.Log("Timer Stop");
        }

        //Override then count
        if (!wrap_clock.Count())
        {
            Debug.Log("WrapTimer:" + wrap_clock.current);
        }
        else
        {
            Debug.Log("WrapTimer Stop");
        }

        //StaticTimer count
        if (!StaticTimer.StaticCount())
        {
            Debug.Log("StaticTimer:" + StaticTimer.current);
        }
        else
        {
            Debug.Log("StaticTimer Stop");
        }
    }
}

//Inherits the timer class.
public class Clock : Timer { }

//override example
public class WrapClock : WrapTimer 
{
    //If less than 5 seconds, set 10 seconds.
    public override void SetTimer(float time)
    {
        limit = (time < 5f) ? 10f : time;
    }

    //Delayed every hundredth of a second.
    public override bool Count()
    {
        current = before + Time.deltaTime - 0.001f;
        before = current;
        return (current > limit) ? true : false;
    }
}