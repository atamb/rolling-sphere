using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadGenerator : MonoBehaviour
{
    public Transform startPos;
    public Transform startPos1;
    float nextStep = 0;
    float nextStep1 = 0;
    public GameObject[] PrefabsRoad;
    public GameObject[] PrefabsPlane;
        
    void Update()
    {
        nextStep += 18;
        Instantiate(PrefabsRoad[Random.Range(0, PrefabsRoad.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
        nextStep1 += 4;
        Instantiate(PrefabsPlane[Random.Range(0, PrefabsPlane.Length)], new Vector3(startPos1.position.x, startPos1.position.y, transform.position.z + nextStep1), Quaternion.identity);
    }
}
