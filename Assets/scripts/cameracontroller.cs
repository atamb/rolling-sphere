using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
[SerializeField] private Vector3 offset;
[SerializeField] private GameObject target;

private void Update() 
{
 Translation(); 
}

private void Translation()
{
    transform.position=target.transform.position + offset;
    transform.LookAt(target.transform.position);
}

}
