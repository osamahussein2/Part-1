using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    // Make the grass tilemap and stepped on tiles objects public
    public GameObject grassTilemap;

    public GameObject grassTilemapSteppedOn1;
    public GameObject grassTilemapSteppedOn2;
    public GameObject grassTilemapSteppedOn3;
    public GameObject grassTilemapSteppedOn4;
    public GameObject grassTilemapSteppedOn5;
    public GameObject grassTilemapSteppedOn6;
    public GameObject grassTilemapSteppedOn7;
    public GameObject grassTilemapSteppedOn8;

    // Make the collider array public to use it in the inspector
    public Collider2D[] colliders;

    // Make the sprite character objects public
    public GameObject osamaSprite, lukaszSprite;

    // Start is called before the first frame update
    void Start()
    {
        // Set the grass tilemap to active since the player has not collided with a tile yet
        grassTilemap.SetActive(true);

        // Disable these stepped on tiles until the player collides to a tile
        grassTilemapSteppedOn1.SetActive(false);
        grassTilemapSteppedOn2.SetActive(false);
        grassTilemapSteppedOn3.SetActive(false);
        grassTilemapSteppedOn4.SetActive(false);
        grassTilemapSteppedOn5.SetActive(false);
        grassTilemapSteppedOn6.SetActive(false);
        grassTilemapSteppedOn7.SetActive(false);
        grassTilemapSteppedOn8.SetActive(false);

        // Initialize the collider array to use it in the inspector
        colliders = gameObject.GetComponents<Collider2D>();
}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // If the player is touching the first collider on the tile, then light up that tile
        if (colliders[1].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[1].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
                grassTilemap.SetActive(false);

                grassTilemapSteppedOn1.SetActive(true);
                grassTilemapSteppedOn2.SetActive(false);
                grassTilemapSteppedOn3.SetActive(false);
                grassTilemapSteppedOn4.SetActive(false);
                grassTilemapSteppedOn5.SetActive(false);
                grassTilemapSteppedOn6.SetActive(false);
                grassTilemapSteppedOn7.SetActive(false);
                grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the second collider on the tile, then light up that tile
        if (colliders[2].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[2].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
            grassTilemap.SetActive(false);

            grassTilemapSteppedOn1.SetActive(false);
            grassTilemapSteppedOn2.SetActive(true);
            grassTilemapSteppedOn3.SetActive(false);
            grassTilemapSteppedOn4.SetActive(false);
            grassTilemapSteppedOn5.SetActive(false);
            grassTilemapSteppedOn6.SetActive(false);
            grassTilemapSteppedOn7.SetActive(false);
            grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the third collider on the tile, then light up that tile
        if (colliders[3].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[3].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
            grassTilemap.SetActive(false);

            grassTilemapSteppedOn1.SetActive(false);
            grassTilemapSteppedOn2.SetActive(false);
            grassTilemapSteppedOn3.SetActive(true);
            grassTilemapSteppedOn4.SetActive(false);
            grassTilemapSteppedOn5.SetActive(false);
            grassTilemapSteppedOn6.SetActive(false);
            grassTilemapSteppedOn7.SetActive(false);
            grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the fourth collider on the tile, then light up that tile
        if (colliders[4].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[4].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
            grassTilemap.SetActive(false);

            grassTilemapSteppedOn1.SetActive(false);
            grassTilemapSteppedOn2.SetActive(false);
            grassTilemapSteppedOn3.SetActive(false);
            grassTilemapSteppedOn4.SetActive(true);
            grassTilemapSteppedOn5.SetActive(false);
            grassTilemapSteppedOn6.SetActive(false);
            grassTilemapSteppedOn7.SetActive(false);
            grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the fifth collider on the tile, then light up that tile
        if (colliders[5].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[5].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
            grassTilemap.SetActive(false);

            grassTilemapSteppedOn1.SetActive(false);
            grassTilemapSteppedOn2.SetActive(false);
            grassTilemapSteppedOn3.SetActive(false);
            grassTilemapSteppedOn4.SetActive(false);
            grassTilemapSteppedOn5.SetActive(true);
            grassTilemapSteppedOn6.SetActive(false);
            grassTilemapSteppedOn7.SetActive(false);
            grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the sixth collider on the tile, then light up that tile
        if (colliders[6].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[6].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
            grassTilemap.SetActive(false);

            grassTilemapSteppedOn1.SetActive(false);
            grassTilemapSteppedOn2.SetActive(false);
            grassTilemapSteppedOn3.SetActive(false);
            grassTilemapSteppedOn4.SetActive(false);
            grassTilemapSteppedOn5.SetActive(false);
            grassTilemapSteppedOn6.SetActive(true);
            grassTilemapSteppedOn7.SetActive(false);
            grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the seventh collider on the tile, then light up that tile
        if (colliders[7].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[7].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
            grassTilemap.SetActive(false);

            grassTilemapSteppedOn1.SetActive(false);
            grassTilemapSteppedOn2.SetActive(false);
            grassTilemapSteppedOn3.SetActive(false);
            grassTilemapSteppedOn4.SetActive(false);
            grassTilemapSteppedOn5.SetActive(false);
            grassTilemapSteppedOn6.SetActive(false);
            grassTilemapSteppedOn7.SetActive(true);
            grassTilemapSteppedOn8.SetActive(false);
        }

        // If the player is touching the eighth collider on the tile, then light up that tile
        if (colliders[8].IsTouching(osamaSprite.GetComponent<Collider2D>())
            || colliders[8].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
        {
                grassTilemap.SetActive(false);

                grassTilemapSteppedOn1.SetActive(false);
                grassTilemapSteppedOn2.SetActive(false);
                grassTilemapSteppedOn3.SetActive(false);
                grassTilemapSteppedOn4.SetActive(false);
                grassTilemapSteppedOn5.SetActive(false);
                grassTilemapSteppedOn6.SetActive(false);
                grassTilemapSteppedOn7.SetActive(false);
                grassTilemapSteppedOn8.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Use the for loop to make it simpler to render the grass tilemap if the player is not touching the colliders
        for (int i = 0; i < colliders.Length; i++)
        {
            if (!colliders[i].IsTouching(osamaSprite.GetComponent<Collider2D>())
                || !colliders[i].IsTouching(lukaszSprite.GetComponent<Collider2D>()))
            {
                grassTilemap.SetActive(true);

                grassTilemapSteppedOn1.SetActive(false);
                grassTilemapSteppedOn2.SetActive(false);
                grassTilemapSteppedOn3.SetActive(false);
                grassTilemapSteppedOn4.SetActive(false);
                grassTilemapSteppedOn5.SetActive(false);
                grassTilemapSteppedOn6.SetActive(false);
                grassTilemapSteppedOn7.SetActive(false);
                grassTilemapSteppedOn8.SetActive(false);
            }
        }
    }
}
