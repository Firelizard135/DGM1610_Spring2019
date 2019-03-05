﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player Movement Variables
    public float moveSpeed;
    public float jumpHeight;

    // Player grounded variables
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        // Left Right Movement
        if(Input.GetKey(KeyCode.D)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.A)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        // Jump
        if(Input.GetKey(KeyCode.W) && grounded) {
            Jump();
        }


    }

    void Jump() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }

}


/*
GetKey = keyboard_check()
GetKeyDown = keyboard_check_pressed
*/