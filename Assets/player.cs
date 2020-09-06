﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpSpeed;
    public float timer;
    public Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -speed;
        }
        else
        {
            velocity.x = 0;
        }
        

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 2;
            velocity.y = jumpSpeed;
        }
        rb.velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Boundary")
        {
            print("collided with boundary");
            transform.position = startingPosition;
        }
        if(collider.gameObject.tag == "Checkpoint")
        {
            startingPosition = collider.transform.position;
        }
    }
}
