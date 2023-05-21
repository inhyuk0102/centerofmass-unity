using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCenterVisualization : MonoBehaviour
{
    public GameObject building; // 건물 오브젝트
    public GameObject centerObject; // 무게중심을 표시할 오브젝트

    private Rigidbody[] rigidbodies; // 건물 내의 Rigidbody 컴포넌트들

    void Start()
    {
        // 건물 내의 Rigidbody 컴포넌트들 가져오기
        rigidbodies = building.GetComponentsInChildren<Rigidbody>();

    }
    
    void Update()
    {
        // 무게중심 계산
        Vector3 centerOfMass = Vector3.zero;
        float totalMass = 0f;

        foreach (Rigidbody rb in rigidbodies)
        {
            centerOfMass += rb.worldCenterOfMass * rb.mass;
            totalMass += rb.mass;
       }


        centerOfMass /= totalMass;

        // 무게중심 오브젝트 이동
        centerObject.transform.position = centerOfMass;
    }
}
