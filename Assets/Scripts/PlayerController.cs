﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 300f;


    void Update()
    {
      
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(speed * Time.deltaTime, 0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
       
    }

    


}
