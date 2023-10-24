using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    public GameObject Car;

    public float speed;

    public float stop;

    public float turnSpeed;

    public float gravity;

    private Vector3 offset;

  

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // if (Input.GetKey(KeyCode.W))
       // {
           // rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed);
       // }


        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-Vector3.forward * stop);
        }

         if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddRelativeForce(-Vector3.forward * stop);
        }
         if (!Input.GetKey(KeyCode.Space))
        {
            Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
            localVelocity.x = 0;
            rb.velocity = transform.TransformDirection(localVelocity);
        }
        

        if (Input.GetKey(KeyCode.D)) 
        {
            rb.AddTorque(Vector3.up * turnSpeed);
        }

       

            if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(Vector3.down * turnSpeed);
        }

        rb.AddForce(Vector3.down * gravity);


    }
}
