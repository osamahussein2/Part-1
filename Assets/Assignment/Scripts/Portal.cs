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

    public GameObject portalCollider;
    public GameObject redPortalCausedByTomato;
    public GameObject yellowOrangePortalCausedByMango;

    // Start is called before the first frame update
    void Start()
    {
        pKeyboard.SetActive(false); // The player hasn't collided with the portal yet

        portalCollider.SetActive(true); // The game should only render this portal at start of runtime

        // These 2 portals will be invisible until a trigger between a fruit and portal occurs
        redPortalCausedByTomato.SetActive(false);
        yellowOrangePortalCausedByMango.SetActive(false);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Turn off the portal in the scene and make red portal visible if the tomato casues the portal trigger
        if (collision.gameObject.tag == "Tomato")
        {
            if (portalCollider.activeInHierarchy)
            {
                portalCollider.SetActive(false);
                redPortalCausedByTomato.SetActive(true);
                yellowOrangePortalCausedByMango.SetActive(false);
            }
        }

        // Turn off the portal in the scene and make yellow orange portal visible if the mango casues the portal trigger
        if (collision.gameObject.tag == "Mango")
        {
            if (portalCollider.activeInHierarchy)
            {
                portalCollider.SetActive(false);
                redPortalCausedByTomato.SetActive(false);
                yellowOrangePortalCausedByMango.SetActive(true);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // If the tomato is still inside the portal trigger, keep the red portal visible until it leaves the trigger
        if(collision.gameObject.tag == "Tomato")
        {
            redPortalCausedByTomato.SetActive(true);
        }

        // If the mango is still inside the portal trigger, keep the yellow orange portal visible until it leaves the trigger
        if (collision.gameObject.tag == "Mango")
        {
            yellowOrangePortalCausedByMango.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // If the tomato leaves the portal trigger, render the portal and make the red portal invisible
        if(collision.gameObject.tag == "Tomato")
        {
            // Enable the portal collider inside the scene and disable the other portals
            if(!portalCollider.activeInHierarchy)
            {
                portalCollider.SetActive(true);

                redPortalCausedByTomato.SetActive(false);
                yellowOrangePortalCausedByMango.SetActive(false);
            }
        }

        // If the mango leaves the portal trigger, render the portal and make the yellow orange portal invisible
        if (collision.gameObject.tag == "Mango")
        {
            // Enable the portal collider inside the scene and disable the other portals
            if (!portalCollider.activeInHierarchy)
            {
                portalCollider.SetActive(true);

                redPortalCausedByTomato.SetActive(false);
                yellowOrangePortalCausedByMango.SetActive(false);
            }
        }
    }
}
