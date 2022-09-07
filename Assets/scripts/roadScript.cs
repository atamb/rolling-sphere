using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadScript : MonoBehaviour
{
    public Transform startPos;
    float nextStep = 35;
    public GameObject[] redRoads;
    public GameObject[] yellowRoads;
    public GameObject[] blueRoads;
    [SerializeField]
    private float i;
    void Start()
    {
        for(i=0;i<3;i++)
        {
            var firstRoad = Instantiate(redRoads[Random.Range(0, redRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            firstRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
        for(i=3;i<6;i++)
        {
            var secondRoad = Instantiate(yellowRoads[Random.Range(0, yellowRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            secondRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
        for(i=6;i<9;i++)
        {
            var thirdRoad = Instantiate(blueRoads[Random.Range(0, blueRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            thirdRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
    }
    
}
