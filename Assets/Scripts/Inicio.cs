using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("WayPoint1"))
        {

            transform.position = new Vector3(-8, 0, -141);


        }
    }
}
