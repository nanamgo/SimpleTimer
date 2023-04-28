//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class WrapTimer
{
    public float current { get; set; } //Current time
    protected float before; //Brfore time
    protected float limit; //Limit time

    public WrapTimer()
    {
        current = 0;
        before = 0;
        limit = 0;
    }

    public virtual void SetTimer(float time)
    {
        limit = time;
    }

    public virtual bool Count()
    {
        current = before + Time.deltaTime;
        before = current;
        return (current > limit) ? true : false;
    }

    public virtual void Reset()
    {
        current = 0;
        before = 0;
        limit = 0;
    }
}
