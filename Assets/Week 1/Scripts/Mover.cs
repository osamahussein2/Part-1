using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Create a predetermined float speed of the tank
    float speedOfTank = 5.0f;

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
    }
}
