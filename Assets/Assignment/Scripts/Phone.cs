using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    // We need 3 game objects to render 3 different phone sprites when a certain fruit causes the phone trigger
    public GameObject phone;
    public GameObject tomatoSpilledOverPhone;
    public GameObject mangoSpilledOverPhone;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize that only the phone sprite to be active in the scene because no fruit has collided into it yet
        phone.SetActive(true);

        tomatoSpilledOverPhone.SetActive(false);
        mangoSpilledOverPhone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* If the tomato tag has collided with the phone, make the tomato spilled over phone sprite active
        to make it seem like the tomato has spilled over the phone as it falls down on the phone */
        if(collision.gameObject.tag == "Tomato")
        {
            phone.SetActive(false);
            tomatoSpilledOverPhone.SetActive(true);
            mangoSpilledOverPhone.SetActive(false);
        }

        /* If the mango tag has collided with the phone, make the mango spilled over phone sprite active
        to make it seem like the mango has spilled over the phone as it falls down on the phone */
        if (collision.gameObject.tag == "Mango")
        {
            phone.SetActive(false);
            tomatoSpilledOverPhone.SetActive(false);
            mangoSpilledOverPhone.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Make the tomato spilled over phone still active if the tomato tag is still colliding with the phone sprite
        if(collision.gameObject.tag == "Tomato")
        {
            tomatoSpilledOverPhone.SetActive(true);
        }

        // Make the mango spilled over phone still active if the mango tag is still colliding with the phone sprite
        if (collision.gameObject.tag == "Mango")
        {
            mangoSpilledOverPhone.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // If the tomato tag left the phone trigger, make the sprite render the phone again in the scene
        if(collision.gameObject.tag == "Tomato")
        {
            if(!phone.activeInHierarchy)
            {
                phone.SetActive(true);

                tomatoSpilledOverPhone.SetActive(false);
                mangoSpilledOverPhone.SetActive(false);
            }
        }

        // If the mango tag left the phone trigger, make the sprite render the phone again in the scene
        if (collision.gameObject.tag == "Mango")
        {
            if (!phone.activeInHierarchy)
            {
                phone.SetActive(true);

                tomatoSpilledOverPhone.SetActive(false);
                mangoSpilledOverPhone.SetActive(false);
            }
        }
    }
}
