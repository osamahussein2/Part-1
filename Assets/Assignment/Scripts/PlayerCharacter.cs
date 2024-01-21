using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Set the player speed to 4 when the player moves their character around
    float playerSpeed = 4.0f;

    // Create a public game object so that I can put my sprite inside the inspector
    public GameObject osamaSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Use these local float variables to get the keyboard input
        float keyboardInputX = Input.GetAxis("Horizontal");
        float keyboardInputY = Input.GetAxis("Vertical");

        // Move the player around the scene horizontally and vertically
        transform.Translate(keyboardInputX * playerSpeed * Time.deltaTime,
            keyboardInputY * playerSpeed * Time.deltaTime, 0);
    }
}
