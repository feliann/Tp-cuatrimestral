using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }

}
