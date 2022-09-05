using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.x>0.01)
        {
            transform.rotation= Quaternion.Euler(0,transform.rotation.y,transform.rotation.z);
        }
    }
}
