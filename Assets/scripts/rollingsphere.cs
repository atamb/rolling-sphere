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
    public float movementSpeed;
    private float horizontalInput;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        distance = Vector3.Distance(other.position, transform.position);
        score.text = "" + (int)distance;
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.position +=new Vector3(horizontalInput * movementSpeed * Time.deltaTime,0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "terrain")
        {
            distance = 0;
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.name == "finisher")
        {
            Debug.Log("Kazandiniz!");
        }
    }
}
