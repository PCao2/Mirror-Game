using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    public bool open = false;
    // todo: public variable for modifying sliding direction

    private Vector3 closedPosition;
    private Vector3 openPosition;

    // Start is called before the first frame update
    void Start()
    {
        closedPosition = transform.position;
        openPosition = new Vector3(closedPosition.x - 1, closedPosition.y, closedPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            transform.position = openPosition;
        } else
        {
            transform.position = closedPosition;
        }
    }
}
