using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToWheel : MonoBehaviour
{

    public WheelCollider wheelC;

    private Vector3 wheelCCenter;
    private RaycastHit hit;

    // Initialization
    void Start()
    {

    }

    // Display
    void Update()
    {
        wheelCCenter = wheelC.transform.TransformPoint(wheelC.center);

        if (Physics.Raycast(wheelCCenter, -wheelC.transform.forward, out hit, wheelC.suspensionDistance + wheelC.radius))
        {
            transform.position = hit.point + (wheelC.transform.forward * wheelC.radius);
        }
        else
        {
            transform.position = wheelCCenter - (wheelC.transform.forward * wheelC.suspensionDistance);
        }
    }
}
