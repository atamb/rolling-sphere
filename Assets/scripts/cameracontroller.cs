using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{

[SerializeField] private float movement;

private void Update() 
{
    movement = Input.acceleration.x;
    transform.rotation = Quaternion.Euler(transform.rotation.x-(movement*10),transform.rotation.x,transform.rotation.x);
}


}
