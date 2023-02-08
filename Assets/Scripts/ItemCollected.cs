using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    // Number of collectibles needed to unlock door
    public int collectGoal = 5;

    public SlideDoor door;

    private int objectsCollected = 0;
    private float scaleMaxHeight;

    // Start is called before the first frame update
    void Start()
    {
        scaleMaxHeight = transform.position.y;
    }

    // Update the scale's position and text based on proportion of collectibles collected
    void AdjustScale()
    {
        float totalMovement = 0.05f;
        float adjustment = (objectsCollected / (float) collectGoal) * totalMovement;
        float scaleNewHeight = scaleMaxHeight - adjustment;

        Vector3 scaleTopNewPosition = new Vector3(transform.position.x, scaleNewHeight, transform.position.z);

        transform.position = scaleTopNewPosition;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            objectsCollected = objectsCollected + 1;
            AdjustScale();
        }

        if (objectsCollected == collectGoal)
        {
            door.open = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            objectsCollected = objectsCollected - 1;
            AdjustScale();
        }
        if (objectsCollected <= collectGoal)
        {
            door.open = false;
        }


    }
}
