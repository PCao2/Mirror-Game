using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    // Number of collectibles needed to unlock door
    public int collectGoal = 5;

    public GameObject door;

    public int objectsCollected = 0;
    private float scaleMaxHeight;

    // Start is called before the first frame update
    void Start()
    {
        scaleMaxHeight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Update the scale's position and text based on proportion of collectibles collected
    void AdjustScale()
    {
        float totalMovement = 0.05f;
        float adjustment = (objectsCollected / (float) collectGoal) * totalMovement;
        float scaleCurrentHeight = scaleMaxHeight - adjustment;

        Vector3 scaleTopPosition = transform.position;
        Vector3 scaleTopNewPosition = new Vector3(scaleTopPosition.x, scaleCurrentHeight, scaleTopPosition.z);

        transform.position = scaleTopNewPosition;
    }

    void UnlockDoor()
    {
        return;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            objectsCollected = objectsCollected + 1;
            AdjustScale();

            if (objectsCollected == collectGoal)
            {
                UnlockDoor();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            objectsCollected = objectsCollected - 1;
            AdjustScale();
        }
    }
}
