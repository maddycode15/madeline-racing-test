using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostScript : MonoBehaviour
{
    public float BoostSpeed;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerStay(Collider other)
        {
            rb.AddRelativeForce(Vector3.forward * BoostSpeed);

        }



        
    }
}
