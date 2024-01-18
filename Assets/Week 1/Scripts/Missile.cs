using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Create a predetermined float for the missile speed
    float missileSpeed = 3.0f;
    Rigidbody2D rigidbody;
    Vector2 direction = new Vector2(10, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the missile to the right on each frame when the player presses the space key to fire the missile
        //transform.Translate(missileSpeed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Missile hit something!");
        Destroy(gameObject);
    }
}
