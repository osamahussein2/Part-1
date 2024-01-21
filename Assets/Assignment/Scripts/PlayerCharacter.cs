using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Set the player speed to 4 when the player moves their character around
    float playerSpeed = 4.0f;

    // Create a public game object so that I can put my sprite inside the inspector
    public GameObject osamaSprite;

    // Create a public game object so that I can use the tomato sprite inside the inspector
    public GameObject tomato;

    /* Create a public transform object so that I can use its game object inside the inspector
    which will control the rigidbody prefab and animate it */
    public Transform dropSomething;

    // Start is called before the first frame update
    void Start()
    {
        // Tell the player what key to press when they start the game to drop fruit
        Debug.Log("Press the SPACE key to drop a fruit!");
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

        // If the player presses the SPACE key, then drop the tomato prefab into the scene
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tomato, dropSomething.transform.position, dropSomething.transform.rotation);
        }
    }
}
