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
    public GameObject[] orangeRoads;
    public GameObject[] blackRoads;
    public GameObject[] purpleRoads;
    public GameObject[] pinkRoads;
    public GameObject[] whiteRoads;
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
        for(i=9;i<12;i++)
        {
            var fourthRoad = Instantiate(orangeRoads[Random.Range(0, orangeRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            fourthRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
        for(i=12;i<15;i++)
        {
            var fifthRoad = Instantiate(blackRoads[Random.Range(0, blackRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            fifthRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
        for(i=15;i<18;i++)
        {
            var sixthRoad = Instantiate(purpleRoads[Random.Range(0, purpleRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            sixthRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
        for(i=18;i<21;i++)
        {
            var seventhRoad = Instantiate(pinkRoads[Random.Range(0, pinkRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            seventhRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
        for(i=21;i<24;i++)
        {
            var eighthRoad = Instantiate(whiteRoads[Random.Range(0, whiteRoads.Length)], new Vector3(startPos.position.x, startPos.position.y, transform.position.z + nextStep), Quaternion.identity);
            eighthRoad.transform.rotation= Quaternion.Euler(-90,180,0);
            nextStep+=112.427f;
        }
    }
    
}
