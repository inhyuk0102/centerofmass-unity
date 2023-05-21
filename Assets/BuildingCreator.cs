using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCreator : MonoBehaviour
{
    public GameObject buildingPrefab; // 건물 프리팹
    public Transform buildingParent; // 건물을 생성할 부모 객체

    public void CreateBuilding()

    {
        // 건물 프리팹을 인스턴스화하여 생성
        GameObject newBuilding = Instantiate(buildingPrefab, buildingParent);

        // 건물 위치를 마우스 클릭 위치로 설정
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
