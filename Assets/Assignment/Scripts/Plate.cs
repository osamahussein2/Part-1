using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    // Add a rigidbody component to add force to the plate
    Rigidbody2D rigidbody;

    // Create a float velocity variable to add force to the plate
    float plateVelocity = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the 2D rigidbody component
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        // Add force to the plate on every fixed frame
        rigidbody.AddForce(transform.position * plateVelocity * Time.deltaTime);
    }
}
