using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Create a predetermined float for the missile speed
    float missileSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the missile to the right on each frame when the player presses the space key to fire the missile
        transform.Translate(missileSpeed * Time.deltaTime, 0, 0);
    }
}
