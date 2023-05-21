using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public Vector3 centerOfMass = new Vector3(0f, -0.5f, 0f);

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (!IsValidVector3(centerOfMass))
        {
            Debug.LogWarning("Invalid Center of Mass");
            return;
        }

        rb.centerOfMass = centerOfMass;
    }

    bool IsValidVector3(Vector3 vector)
    {
        return !float.IsNaN(vector.x) && !float.IsNaN(vector.y) && !float.IsNaN(vector.z);
    }
}
