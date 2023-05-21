using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCreator : MonoBehaviour
{    
    public GameObject buildingPrefabQ; // �ǹ� ������1
    public GameObject buildingPrefabW; // �ǹ� ������2
    public GameObject buildingPrefabE; // �ǹ� ������3
    public Transform buildingParent; // �ǹ��� ������ �θ� ��ü


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // �ǹ� �������� �ν��Ͻ�ȭ�Ͽ� ����
            GameObject newBuildingQ = Instantiate(buildingPrefabQ, buildingParent);

            // �ǹ� ��ġ�� ���콺 Ŭ�� ��ġ�� ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                newBuildingQ.transform.position = hit.point;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // �ǹ� �������� �ν��Ͻ�ȭ�Ͽ� ����
            GameObject newBuildingW = Instantiate(buildingPrefabW, buildingParent);

            // �ǹ� ��ġ�� ���콺 Ŭ�� ��ġ�� ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                newBuildingW.transform.position = hit.point;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // �ǹ� �������� �ν��Ͻ�ȭ�Ͽ� ����
            GameObject newBuildingE = Instantiate(buildingPrefabE, buildingParent);

            // �ǹ� ��ġ�� ���콺 Ŭ�� ��ġ�� ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                newBuildingE.transform.position = hit.point;
            }


        }



    }

}