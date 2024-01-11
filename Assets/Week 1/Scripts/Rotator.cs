using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Create a float to predetermine the speed of the rotating hands (only for the minute hand)
    public float speedOfRotation = 360.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the hands by this speed below and add the Time.deltaTime to update the rotation by frame
        transform.Rotate(Vector3.forward, -speedOfRotation * Time.deltaTime);
    }
}
