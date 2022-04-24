using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float inputForwardForce = 2000f;
    public float upwardForce = 100f;
    public float sidewayForce = 300f;


    // Update is called once per frame

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force of "forwardForce" on the z-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, inputForwardForce * Time.deltaTime);
        }        

    }
}
