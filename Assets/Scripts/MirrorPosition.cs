using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MirrorPosition : MonoBehaviour
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

        // Reverse rotation around x- and y-axis
        float parentAngle = 0.0f;
        Vector3 parentAxis = Vector3.zero;
        parentRotation.ToAngleAxis(out parentAngle, out parentAxis);
        Vector3 mirrorAxis = new Vector3(-parentAxis.x, -parentAxis.y, parentAxis.z);

        Vector3 mirrorPosition = new Vector3(parentPosition.x, parentPosition.y, -parentPosition.z);
        Quaternion mirrorRotation = Quaternion.AngleAxis(parentAngle, mirrorAxis);

        mirrorChild.transform.SetPositionAndRotation(mirrorPosition, mirrorRotation);
    }
}
