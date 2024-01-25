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

    //public GameObject oil, oil2, oil3;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "oil" || collision.gameObject.name == "oil (1)" || collision.gameObject.name == "oil (2)")
        {
            Debug.Log("You entered the oil slick!");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "oil" || collision.gameObject.name == "oil (1)" || collision.gameObject.name == "oil (2)")
        {
            rigidbody.AddTorque((steeringSpeed * steeringInput - 200) * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "oil" || collision.gameObject.name == "oil (1)" || collision.gameObject.name == "oil (2)")
        {
            rigidbody.AddTorque(steeringSpeed * steeringInput * Time.deltaTime);
        }
    }
}
