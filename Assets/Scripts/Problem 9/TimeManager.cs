using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static int duration;

    public static float time;
    void Start()
    {
        time = 0;
    }
    public static void AddDuration (int value)
    {
        duration += value;
    }
}
