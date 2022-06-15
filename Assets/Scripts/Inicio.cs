using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public static float random = 0;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("WayPoint1"))
        {
        //    random = Random.Range(-3, -24);
            //Debug.Log(random);
            //Debug.Log("hola");
            transform.position = new Vector3(-3.5f, -20.25948f, -130.687f);


        }
    }
}
