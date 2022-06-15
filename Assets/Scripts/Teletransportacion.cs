using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportacion : MonoBehaviour
{

    
    private void OnCollisionEnter(Collision collision)
    {
                         
           if (collision.gameObject.CompareTag("WayPoint1"))
        {
            //random = Random.Range(-3, -24);
          
            //transform.position = new Vector3 (-21,0, -146);


        }
    }

}