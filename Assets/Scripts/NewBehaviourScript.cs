using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("WayPoint1"))
        {

            transform.position = new Vector3(-14, 0, -90);


        }
    }
}
