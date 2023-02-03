using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MirrorPosition1 : MonoBehaviour
{
    public GameObject mirrorParent;

    public GameObject mirrorChild;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 parentPosition = mirrorParent.transform.position;
        Quaternion parentRotation = mirrorParent.transform.rotation;

        mirrorChild.transform.SetPositionAndRotation(parentPosition, parentRotation);
    }
}
