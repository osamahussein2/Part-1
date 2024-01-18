using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the door is enabled in the hierarchy, disable the door (despawn the door)
        if (door.activeInHierarchy)
        {
            Debug.Log("Despawn door!");
            door.SetActive(false);
        }

        // Else if the door is disabled in the hierarchy, enable the door (spawn the door)
        else if (!door.activeInHierarchy)
        {
            Debug.Log("Spawn door!");
            door.SetActive(true);
        }
    }
}
