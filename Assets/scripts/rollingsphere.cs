using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class rollingsphere : MonoBehaviour
{

    public Transform other;
    public float distance;
    public TextMeshProUGUI score;
    public float speed;
    public float verticalSpeed;
    Rigidbody rb;
    private float xInput;
    public float zInput;
    private Vector3 velocity;
    private Vector3 verticalVelocity;
    public float zOffset;
    public float zVelocity;


    void Start()
    {
        rb=GetComponent<Rigidbody>();
        verticalVelocity *= -1;
    }

    

    void Update()
    {
        horizontalMovement();
        verticalMovement(); 
        pcMovement();
        GetDistance();
    }

    private void pcMovement()
    {
        Vector3 hiz = new Vector3(Input.GetAxis("Horizontal"),0f,Input.GetAxis("Vertical"));
        rb.AddForce(hiz*speed*Time.deltaTime);
    }
    
    private void horizontalMovement()
    {

        speed = 100;
        xInput = Input.acceleration.x; 
        
        if(xInput>1)
        {
            xInput=1;
        }
        if(xInput<-1)
        {
            xInput=-1;
        }
        if(zInput>1)
        {
            zInput=1;
        }
        if(zInput<-1)
        {
            zInput=-1;
        }

        velocity = new Vector3(xInput, 0 ,0);

        rb.AddForce(velocity*speed*Time.deltaTime);
    }

    private void verticalMovement()
    {

        verticalSpeed = -80;

        zInput = Input.acceleration.z;
        
        verticalVelocity = new Vector3(0, 0 ,zVelocity);

        rb.AddForce(verticalVelocity*verticalSpeed*Time.deltaTime);
    }



    private void GetDistance()
    {
        distance = Vector3.Distance(other.position, transform.position);
        score.text = "" + (int)distance/2;
        if(transform.position.y<-1)
        {
            xInput = 0;
            transform.position= new Vector3(0,1,0);
            speed = 0;
        }
        
        if(distance> PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", (int)distance/2);
        }
    }

    public void offsetButton()
    {
        zVelocity=zInput-zOffset;
    }


}
