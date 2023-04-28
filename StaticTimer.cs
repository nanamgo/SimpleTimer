//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public static class StaticTimer
{
    public static float current { get; set; } //Current time
    static float before; //Brfore time
    static float limit; //Limit time

    static StaticTimer()
    {
        current = 0;
        before = 0;
        limit = 0;
    }

    public static void SetStaticTimer(float time)
    {
        limit = time;
    }

    public static bool StaticCount()
    {
        current = before + Time.deltaTime;
        before = current;
        return (current > limit) ? true : false;
    }

    public static void StaticReset()
    {
        current = 0;
        before = 0;
        limit = 0;
    }
}
