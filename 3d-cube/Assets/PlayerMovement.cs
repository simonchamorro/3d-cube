using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 600f;

    void Start()
    {

    }

    void FixedUpdate() // Use Fixed Update for physics 
    {
        // Add forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        // Not the best way to get user input
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0);
        }
    }
}
