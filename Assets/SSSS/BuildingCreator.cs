using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCreator : MonoBehaviour
{    
    public GameObject buildingPrefabQ; // 건물 프리팹1
    public GameObject buildingPrefabW; // 건물 프리팹2
    public GameObject buildingPrefabE; // 건물 프리팹3
    public Transform buildingParent; // 건물을 생성할 부모 객체


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 건물 프리팹을 인스턴스화하여 생성
            GameObject newBuildingQ = Instantiate(buildingPrefabQ, buildingParent);

            // 건물 위치를 마우스 클릭 위치로 설정
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                newBuildingQ.transform.position = hit.point;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 건물 프리팹을 인스턴스화하여 생성
            GameObject newBuildingW = Instantiate(buildingPrefabW, buildingParent);

            // 건물 위치를 마우스 클릭 위치로 설정
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                newBuildingW.transform.position = hit.point;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // 건물 프리팹을 인스턴스화하여 생성
            GameObject newBuildingE = Instantiate(buildingPrefabE, buildingParent);

            // 건물 위치를 마우스 클릭 위치로 설정
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                newBuildingE.transform.position = hit.point;
            }


        }



    }

}