﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player Movement Variables
    public float moveSpeed;
    public float jumpHeight;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        grounded = true;
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
        if(Input.GetKey(KeyCode.W)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }
}

/*
GetKey = keyboard_check()
GetKeyDown = keyboard_check_pressed
*/