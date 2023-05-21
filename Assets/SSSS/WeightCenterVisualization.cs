using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCenterVisualization : MonoBehaviour
{
    public GameObject building; // �ǹ� ������Ʈ
    public GameObject centerObject; // �����߽��� ǥ���� ������Ʈ

    private Rigidbody[] rigidbodies; // �ǹ� ���� Rigidbody ������Ʈ��

    void Start()
    {
        // �ǹ� ���� Rigidbody ������Ʈ�� ��������
        rigidbodies = building.GetComponentsInChildren<Rigidbody>();

    }
    

    void Massofcenter()
    {
        // �����߽� ���
        Vector3 centerOfMass = Vector3.zero;
        float totalMass = 0f;

        foreach (Rigidbody rb in rigidbodies)
        {
            centerOfMass += rb.worldCenterOfMass * rb.mass;
            totalMass += rb.mass;
        }


        centerOfMass /= totalMass;

        // �����߽� ������Ʈ �̵�
        centerObject.transform.position = centerOfMass;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            rigidbodies = building.GetComponentsInChildren<Rigidbody>();

        }
        Massofcenter();
    }
}
