using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class rollingsphere : MonoBehaviour
{

    public Transform other;
    public float distance;
    public TextMeshProUGUI score;
    public float speed;
    Rigidbody rb;
    private float xInput;
    private float zInput;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
    

    void Update()
    {
        Movement();
        GetDistance();
    }


    private void Movement()
    {
        speed = 400;
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        if(xInput>0.1f)
        {
            xInput=0.1f;
        }
        if(xInput<-0.1f)
        {
            xInput=-0.1f;
        }
        if(zInput>0.1f)
        {
            zInput=0.1f;
        }
        if(zInput<-0.1f)
        {
            zInput=-0.1f;
        }
        Vector3 velocity = new Vector3(xInput, 0 ,zInput);
        rb.AddForce(velocity*speed*Time.deltaTime);
    }

    private void GetDistance()
    {
        distance = Vector3.Distance(other.position, transform.position);
        score.text = "" + (int)distance;
        if(transform.position.y<-1)
        {
            zInput = 0;
            xInput = 0;
            transform.position= new Vector3(0,1,0);
            speed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "terrain")
        {
            distance = 0;
            transform.position= new Vector3(0,1,0);
        }

    }
}
