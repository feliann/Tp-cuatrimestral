using System;
using UnityEngine;
using System.Timers;

public class Switch : MonoBehaviour
{
    public GameObject textObj;

    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        textObj.SetActive(false);
        timer = new Timer(10);
        timer.AutoReset = false;
        timer.Elapsed += ElapsedHandler;
        timer.Start();
    }

    private void ElapsedHandler(System.Object sender, EventArgs evtArgs)
    {
        Debug.Log("Timer elapsed.");
        textObj.SetActive(true);
        Debug.Log("End reached.");
    }
}