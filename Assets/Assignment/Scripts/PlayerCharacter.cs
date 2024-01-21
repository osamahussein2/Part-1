using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Set the player speed to 4 when the player moves their character around
    float playerSpeed = 4.0f;

    // Create a public game object so that I can put my sprite and my friend's sprite inside the inspector
    public GameObject osamaSprite;
    public GameObject lukaszSprite;

    // Create a public game object so that I can use the tomato and mango sprites inside the inspector
    public GameObject tomato;
    public GameObject mango;

    /* Create 2 public transform objects so that I can use their game objects inside the inspector
    which will control the rigidbody prefab and animate it */
    public Transform dropSomething;
    public Transform dropSomething2;

    // Start is called before the first frame update
    void Start()
    {
        // Tell the player what key to press when they start the game to drop fruit
        Debug.Log("Press the SPACE key to drop a fruit!");

        // Reason for this is that I want to render one sprite at a time at the start of the game
        osamaSprite.SetActive(true);
        lukaszSprite.SetActive(false);
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
            // If the player plays as Osama and the SPACE key is pressed, drop the tomato prefab
            if (osamaSprite.activeInHierarchy && !lukaszSprite.activeInHierarchy)
            {
                Instantiate(tomato, dropSomething.transform.position, dropSomething.transform.rotation);
            }

            // If the player plays as Lukasz and the SPACE key is pressed, drop the mango prefab
            if (lukaszSprite.activeInHierarchy && !osamaSprite.activeInHierarchy)
            {
                Instantiate(mango, dropSomething2.transform.position, dropSomething2.transform.rotation);
            }
        }
    }
}
