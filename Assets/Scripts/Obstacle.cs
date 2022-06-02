using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Obstacle : MonoBehaviour
{

    public GameObject Player;

    private void OnCollisionEnter(Collision collision)
       
    {
       
        if (collision.transform.CompareTag("Player"))
        {
          Debug.Log("muerto");
        }
    }
}

        