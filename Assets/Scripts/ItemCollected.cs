using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    public int objectsCollected;

    // Number of collectibles needed to unlock door
    private int collectGoal = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        return;
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
        }
    }
}
