using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class rollingsphere : MonoBehaviour
{

    gameManager gm;
    public Transform other;
    public float distance;
    public int levels;
    public TextMeshProUGUI score;
    public float speed;
    public float verticalSpeed;
    Rigidbody rb;
    private float xInput;
    public float zInput;
    [SerializeField] private float zPosition;

    [SerializeField] private float highScore;
    private Vector3 velocity;
    private Vector3 verticalVelocity;
    public float zOffset;
    public float zVelocity;
    [SerializeField] private GameObject objsphere;
    [SerializeField] private Texture fstBallText;
    [SerializeField] private Texture secBallText;
    [SerializeField] private Texture thrBallText;
    [SerializeField] private Texture frtBallText;
    [SerializeField] private Texture fthBallText;
    [SerializeField] private Texture sxtBallText;
    [SerializeField] private Texture svtBallText;
    [SerializeField] private Texture egtBallText;
    private Renderer renderSphere;
    public Material secondSkybox;
    public Material thirdSkybox;
    [SerializeField] private ParticleSystem finishingparticle;

    


    void Start()
    {
        gm=GameObject.Find("gameManager").GetComponent<gameManager>();
        zOffset=0;
        verticalSpeed = -100;
        speed = 120;
        rb=GetComponent<Rigidbody>();
        verticalVelocity *= -1;
        renderSphere = objsphere.GetComponent<Renderer>();
        levels=PlayerPrefs.GetInt("levelWanted");
        levelController();
        transform.position= new Vector3(0,1,zPosition);
    }

    void Update()
    {
        horizontalMovement();
        verticalMovement(); 
        pcMovement();
        GetDistance();
        SetNewColor();
        OpenBalls();
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
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name=="tree")
        {
            finishingparticle.Play();
            Invoke("Finished",1f);
        }
    }
    
    private void verticalMovement()
    {
        zInput = Input.acceleration.z;
        verticalSpeed = -100;
       
        verticalVelocity = new Vector3(0, 0 ,zInput-zOffset);

        rb.AddForce(verticalVelocity*verticalSpeed*Time.deltaTime);
    }

    private void levelController()
    {
        switch(levels)
        {
            case 1:
            zPosition = 0;
            break;

            case 2:
            zPosition = 373;
            break;

            case 3:
            zPosition = 710;
            break;

            case 4:
            zPosition = 1048;
            break;

            case 5:
            zPosition = 1384;
            break;

            case 6:
            zPosition = 1721;
            break;

            case 7:
            zPosition = 2058;
            break;

            case 8:
            zPosition = 2395;
            break;
        }
    }

    private void SetNewColor()
    {
        levels=PlayerPrefs.GetInt("levelWanted");

        if(transform.position.z<373)
        {
            renderSphere.material.SetTexture("_MainTex", fstBallText);
            RenderSettings.skybox = thirdSkybox;
            zPosition=0;
        }
        else if(transform.position.z>373 && transform.position.z<710)
        {
            renderSphere.material.SetTexture("_MainTex", secBallText);
            RenderSettings.skybox = secondSkybox;
            zPosition=373;
        }
        else if(transform.position.z>710 && transform.position.z<1048)
        {
            renderSphere.material.SetTexture("_MainTex", thrBallText);
            RenderSettings.skybox = thirdSkybox;
            zPosition=710;
        }
        else if(transform.position.z>1048 && transform.position.z<1384)
        {
            renderSphere.material.SetTexture("_MainTex", frtBallText);
            RenderSettings.skybox = secondSkybox;
            zPosition=1048;
        }
        else if(transform.position.z>1384 && transform.position.z<1721)
        {
            renderSphere.material.SetTexture("_MainTex", fthBallText);
            RenderSettings.skybox = thirdSkybox;
            zPosition=1384;
        }
        else if(transform.position.z>1721 && transform.position.z<2058)
        {
            renderSphere.material.SetTexture("_MainTex", sxtBallText);
            RenderSettings.skybox = secondSkybox;
            zPosition=1721;
        }
        else if(transform.position.z>2058 && transform.position.z<2395 )
        {
            renderSphere.material.SetTexture("_MainTex", svtBallText);
            RenderSettings.skybox = thirdSkybox;
            zPosition=2058;
        }
        else if(transform.position.z>2395)
        {
            renderSphere.material.SetTexture("_MainTex", egtBallText);
            RenderSettings.skybox = secondSkybox;
            zPosition=2395;
        }
    }

    private void GetDistance()
    {
        distance = Vector3.Distance(other.position, transform.position);
        score.text = "" + (int)distance/2;
        if(transform.position.y<-1)
        {
            xInput = 0;
            transform.position= new Vector3(0,1,zPosition);
            speed = 0;
            gm.count+=1;
            renderSphere.material.SetTexture("_MainTex", fstBallText);
            RenderSettings.skybox = thirdSkybox;
        }
        
        if(distance> PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", (int)distance);
        }
    }

    private void OpenBalls()
    {
        if(PlayerPrefs.GetInt("highScore")>0)
        {
            PlayerPrefs.SetInt("openedLevel", 1);
        }
        if(PlayerPrefs.GetInt("highScore")>=373)
        {
            PlayerPrefs.SetInt("openedLevel", 2);
        }
        if(PlayerPrefs.GetInt("highScore")>=710)
        {
            PlayerPrefs.SetInt("openedLevel", 3);
        }
        if(PlayerPrefs.GetInt("highScore")>=1048)
        {
            PlayerPrefs.SetInt("openedLevel", 4);
        }
        if(PlayerPrefs.GetInt("highScore")>=1384)
        {
            PlayerPrefs.SetInt("openedLevel", 5);
        }
        if(PlayerPrefs.GetInt("highScore")>=1721)
        {
            PlayerPrefs.SetInt("openedLevel", 6);
        }
        if(PlayerPrefs.GetInt("highScore")>=2058)
        {
            PlayerPrefs.SetInt("openedLevel", 7);
        }
        if(PlayerPrefs.GetInt("highScore")>=2395)
        {
            PlayerPrefs.SetInt("openedLevel", 8);
        }
    }

    public void offsetButton()
    {
        zOffset=Input.acceleration.z;
    }

    private void Finished()
    {
       SceneManager.LoadScene(2);
    }


}
