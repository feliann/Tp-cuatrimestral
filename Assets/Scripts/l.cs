using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l : MonoBehaviour
{
    public float delta = 10f;
    public float speed = 0.5f;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}

