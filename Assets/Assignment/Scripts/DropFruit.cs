using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFruit : MonoBehaviour
{
    // This is needed to make kinematic fruit objects that will drop in the scene
    Rigidbody2D rigidbody;

    // The fruit will be dropped below the player when the player presses the SPACE key
    Vector2 dropFruitDirection = new Vector2(0.0f, -5.0f);

    // Start is called before the first frame update
    void Start()
    {
        // Initalize rigidbody as a component for use inside Unity
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Drop the fruit at every fixed interval
        rigidbody.MovePosition(rigidbody.position + dropFruitDirection * Time.deltaTime);

        // If the fruit goes below the camera, then destroy it entirely
        if(rigidbody.position.y <= -5.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When the fruit hits something, the fruit will be destroyed
        Destroy(gameObject);
    }
}
