using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCreator : MonoBehaviour
{
    public GameObject buildingPrefab; // �ǹ� ������
    public Transform buildingParent; // �ǹ��� ������ �θ� ��ü

    public void CreateBuilding()

    {
        // �ǹ� �������� �ν��Ͻ�ȭ�Ͽ� ����
        GameObject newBuilding = Instantiate(buildingPrefab, buildingParent);

        // �ǹ� ��ġ�� ���콺 Ŭ�� ��ġ�� ����
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            newBuilding.transform.position = hit.point;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
            CreateBuilding();
    }
}
