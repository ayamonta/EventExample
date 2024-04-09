using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScript : MonoBehaviour
{
    public TimerScript timer;

    private void Awake()
    {
        timer = gameObject.AddComponent<TimerScript>();
        EventScript.timeIsUp.AddListener(print);
    }

    // Start is called before the first frame update
    void Start()
    {
        timer.ActivateTimer();
        timer.EndPoint = 2.5f;
        Debug.Log($"elapsed: {timer.Elapsed}");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.UnderTime())
        {
            timer.CountUp();
        }
        else
        {
            EventScript.timeIsUp.Invoke();
            timer.RestartTimer();
        }
        
    }

    public void print()
    {
        Debug.Log($"player: time has run out");
    }

}
