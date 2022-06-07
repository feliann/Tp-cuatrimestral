using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportacion : MonoBehaviour
{

  
    private void OnCollisionEnter(Collision collision)
    {
                         
           if (collision.gameObject.CompareTag("WayPoint1"))
        {
           
            transform.position = new Vector3 (-21,0, -146);


        }
    }

}