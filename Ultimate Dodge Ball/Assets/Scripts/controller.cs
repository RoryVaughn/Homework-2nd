﻿using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour
{
    int jumpcount = 0;
    public float jump = 4.0f;
    public float speed = 5.0f;
    public GameObject border;
    //private Vector3 move = Vector3.zero;
    // Use this for initialization

    void Start()
    {
        transform.position = new Vector3(0, 4, -3);
        Instantiate(border, new Vector3(-2, 0, 6), Quaternion.identity);
        Instantiate(border, new Vector3(12, 0, 6), Quaternion.identity);
    }
    void Jumpup(float y)
    {
     //    = jump;
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        //}
       // if (Input.GetKeyDown(KeyCode.D))
        //{
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") *speed * Time.deltaTime);
        //}
        
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") *speed * Time.deltaTime);
            
       

        if (Input.GetKeyUp(KeyCode.Space))
        {

            
            
            jumpcount++;

            if (jumpcount == 2)
            {

            }
        }

    }
}
