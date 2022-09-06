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
    [SerializeField] private GameObject objsphere;
    [SerializeField] private Texture fstBallText;
    [SerializeField] private Texture secBallText;
    [SerializeField] private Texture thrBallText;
    private Renderer renderSphere;
    public Material secondSkybox;
    public Material thirdSkybox;
    


    void Start()
    {
        zOffset=0;
        verticalSpeed = -100;
        speed = 120;
        rb=GetComponent<Rigidbody>();
        verticalVelocity *= -1;
        renderSphere = objsphere.GetComponent<Renderer>();
    }

    

    void Update()
    {
        horizontalMovement();
        verticalMovement(); 
        pcMovement();
        GetDistance();
        SetNewColor();
    }

    private void pcMovement()
    {
        Vector3 hiz = new Vector3(Input.GetAxis("Horizontal"),0f,Input.GetAxis("Vertical"));
        rb.AddForce(hiz*speed*Time.deltaTime);
    }
    
    private void horizontalMovement()
    {
        xInput = Input.acceleration.x; 
        speed = 120;

        if(xInput>1)
        {
            xInput=1;
        }
        if(xInput<-1)
        {
            xInput=-1;
        }

        velocity = new Vector3(xInput, 0 ,0);

        rb.AddForce(velocity*speed*Time.deltaTime);
    }

    private void verticalMovement()
    {
        zInput = Input.acceleration.z;
        verticalSpeed = -100;

        if(zInput>1)
        {
            zInput=1;
        }
        if(zInput<-1)
        {
            zInput=-1;
        }
        
        verticalVelocity = new Vector3(0, 0 ,zInput-zOffset);

        rb.AddForce(verticalVelocity*verticalSpeed*Time.deltaTime);
    }

    private void SetNewColor()
    {
        if(transform.position.z>141)
        {
            renderSphere.material.SetTexture("_MainTex", secBallText);
            RenderSettings.skybox = secondSkybox;
        }
        if(transform.position.z>245.5f)
        {
            renderSphere.material.SetTexture("_MainTex", thrBallText);
            RenderSettings.skybox = thirdSkybox;
        }
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
            renderSphere.material.SetTexture("_MainTex", fstBallText);
            RenderSettings.skybox = thirdSkybox;
        }
        
        if(distance> PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", (int)distance/2);
        }
    }

    public void offsetButton()
    {
        zOffset=Input.acceleration.z;
    }


}
