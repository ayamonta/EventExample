using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{

    /// <summary> Default value (= 0) when timer begins </summary>
    public float startPoint = 0;
    /// <summary> End of timer duration </summary>
    public float endPoint = 2.5f;
    /// <summary> Running time...current total time during runtime </summary>
    public float elapsed = 0;
    /// <summary> If the timer is still counting up </summary>
    public bool running = false;


    /// <summary> (optional) Set beginning point when timer starts </summary>
    public float StartPoint 
    { 
        get => startPoint; 
        set => startPoint = value; 
    }
    /// <summary> Set deadline when timer restarts </summary>
    public float EndPoint 
    { 
        get => endPoint; 
        set => endPoint = value; 
    }
    public float Elapsed => elapsed;
    public bool Running => running;


    public void DeactivateTimer()
    {
        running = false;
    }
        
    public void ActivateTimer()
    {
        running = true;
    }

    public void KillTimer()
    {
        // destroy object
    }

    public void CountUp()
    {
        if (!running)
        {
            return;
        }
        if (running)
        {
            elapsed += Time.deltaTime;
            running = true;
        }

    }

    public void RestartTimer()
    {
        elapsed = startPoint;
    }

    public bool UnderTime()
    {
        return (elapsed < endPoint);
    }

    public bool OverTime()
    {
        return (elapsed > endPoint);
    }

}

