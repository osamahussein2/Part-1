using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Create a predetermined float for the rotation speed of the turret
    float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Create a local variable to the get the keyboard input along the vertical axis
        float turretRotationDirection = Input.GetAxis("Vertical");

        // Rotate the turret up and down via keyboard input
        transform.Rotate(0, 0, turretRotationDirection * rotationSpeed * Time.deltaTime);
    }
}
