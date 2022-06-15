using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetMover : MonoBehaviour
{
    public Transform target;
    
    public float speed;
    //public GameObject wayPoint1;
    //float _random = Inicio.random;

    private void Update()
    {
        
        //wayPoint1.transform.position = new Vector3 (_random, 0, -2.2f);
        //Debug.Log(wayPoint1.transform.position);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position,step);

    }

}