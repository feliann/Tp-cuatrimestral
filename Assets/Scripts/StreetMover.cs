using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetMover : MonoBehaviour
{
    public Transform target;
    public float speed;

  
    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position,step);

    }

}