using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // We need a public game object to connect the portal's collision between the 2 playable sprites
    public GameObject osamaSprite;
    public GameObject lukaszSprite;

    // This is used to enable p keyboard sprite in the scene once the player collides with the portal
    public GameObject pKeyboard;

    // Start is called before the first frame update
    void Start()
    {
        pKeyboard.SetActive(false); // The player hasn't collided with the portal yet
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When the player collides into it, make p keyboard sprite visible for the player
        if(!pKeyboard.activeInHierarchy)
        {
            pKeyboard.SetActive(true);

            // Just in case if the player can't see on the scene which key to press
            Debug.Log("Press 'P' on keyboard to switch characters! " +
                "(Warning: the game might not let you switch characters until you collide into " +
                "it again or you roam around the portal while pressing the P key)");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Sometimes the game won't let you switch characters until you collide with the portal again or if you keep roaming around it
        if (collision.gameObject.tag == "Osama")
        {
            /* If the player presses P key while still inside the portal's collision zone, change
            change from Osama's character to Lukasz's character */
            if(Input.GetKeyDown(KeyCode.P))
            {
                if(osamaSprite.activeInHierarchy)
                {
                    osamaSprite.SetActive(false);
                    lukaszSprite.SetActive(true);
                }
            }
        }

        // Sometimes the game won't let you switch characters until you collide with the portal again or if you keep roaming around it
        if (collision.gameObject.tag == "Lukasz")
        {
            /* If the player presses P key while still inside the portal's collision zone, change
            change from Lukasz's character to Osama's character */
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (lukaszSprite.activeInHierarchy)
                {
                    lukaszSprite.SetActive(false);
                    osamaSprite.SetActive(true);
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // When the player leaves the portal's collision zone, make the p keyboard sprite invisible
        if(pKeyboard.activeInHierarchy)
        {
            pKeyboard.SetActive(false);
        }
    }
}
