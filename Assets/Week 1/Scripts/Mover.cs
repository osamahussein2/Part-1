using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Create a predetermined float speed of the tank
    float speedOfTank = 5.0f;

    // Create a public missile prefab game object
    public GameObject missilePrefab;

    public Transform barrel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Create a local variable to take it the float of keyboard input, when the player presses a key on the keyboard
        float keyboardInput = Input.GetAxis("Horizontal");

        // Move the tank around horizontally depending on the keyboard input (pressed by the player) and the speed of the tank float
        transform.Translate(keyboardInput * speedOfTank * Time.deltaTime, 0, 0);
        
        // If the player presses space key
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Makes the missile appear
            Instantiate(missilePrefab, barrel.position, barrel.rotation);
        }
    }
}
