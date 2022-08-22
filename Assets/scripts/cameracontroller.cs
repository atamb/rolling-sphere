using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 targetedposition;
    public Vector3 offset;
    public Vector3 velocity;
    public float smoothTime = 0.3f;
    public float rotationPositive = 1;
    public float rotationNegative = -1;

    void Start()
    {
        transform.position = targetObject.transform.position + offset;
    }

    void Update() 
    {
        
    }
   

    void LateUpdate()
    {
        targetedposition = targetObject.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetedposition, ref velocity, smoothTime);
    }
}
