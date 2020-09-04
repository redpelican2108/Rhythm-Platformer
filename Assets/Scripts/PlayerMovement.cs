using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    Rigidbody2D rb;
    SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 velocity = rb.velocity;

        if (Input.GetKey(KeyCode.RightArrow)) {
            velocity.x = moveSpeed;
            sr.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            velocity.x = -moveSpeed;
            sr.flipX = true;
        }
        else
        {
            velocity.x = 0;
        }
        rb.velocity = velocity;
    }
}