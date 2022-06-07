using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Obstacle : MonoBehaviour
{

    public GameObject Player;
    public bool gameover;
    public GameObject canvas;
    public bool EstaEnElSuelo = true;
    private void OnCollisionEnter(Collision collision)
      
       
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
           EstaEnElSuelo = true;
          
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            SceneManager.LoadScene("GameOver");


        }
    }
}

        