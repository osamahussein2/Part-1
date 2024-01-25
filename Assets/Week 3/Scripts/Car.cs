using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float forwardSpeed;
    float forwardInput;

    public float steeringSpeed;
    float steeringInput;

    public float maxSpeed;

    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        steeringInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steeringSpeed * steeringInput * Time.deltaTime);

        Vector2 force = transform.up * forwardSpeed * forwardInput * Time.deltaTime;

        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }
    }
}
