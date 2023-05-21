using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torque : MonoBehaviour
{
    public float torqueMagnitude = 10f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(torqueMagnitude * Vector3.right, ForceMode.Impulse);
        rb.AddTorque(torqueMagnitude * Vector3.up, ForceMode.Impulse);
        rb.AddTorque(torqueMagnitude * Vector3.forward, ForceMode.Impulse);
    }

    void Update()
    {
        OnDrawGizmos();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, torqueMagnitude * transform.right);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, torqueMagnitude * transform.up);

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, torqueMagnitude * transform.forward);
    }
}
