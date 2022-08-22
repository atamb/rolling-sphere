using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadScript : MonoBehaviour
{
    public Transform startPos;
    float nextStep = 0;
    public GameObject[] redRoads;
    public GameObject[] yellowRoads;
    [SerializeField]
    private float i;
    void Start()
    {
        for(i=0;i<3;i++)
        {
            nextStep+=67.46f;
            var firstRoad = Instantiate(redRoads[Random.Range(0, redRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            firstRoad.transform.rotation= Quaternion.Euler(-90,0,180);
        }
        for(i=3;i<6;i++)
        {
            nextStep+=67.46f;
            var secondRoad = Instantiate(yellowRoads[Random.Range(0, yellowRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            secondRoad.transform.rotation= Quaternion.Euler(-90,0,180);
        }
    }
    
}
