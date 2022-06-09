using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tiemer : MonoBehaviour
{


    public Text txt_timeFloored;
    float currentTime;
    void Update()
    {
        currentTime = Time.timeSinceLevelLoad;

        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();
        if (currentTime > 10)
        {
            SceneManager.LoadScene("Win"); ;
        }

    }
}
    