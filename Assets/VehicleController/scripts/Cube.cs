using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour
{
    public GameObject ball;
    public float speed = 1;


    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Passenger");
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 destinationVector = (ball.transform.position - transform.position).normalized;
        destinationVector.y = 0;
       transform.Translate(destinationVector * speed * Time.deltaTime); 
       
    }
}