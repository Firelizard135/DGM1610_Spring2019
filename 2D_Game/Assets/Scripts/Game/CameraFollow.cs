﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public PlayerController player;

    public bool isFollowing;
    public float smoothTime; //How long it takes to catch up to the target
    private Vector3 target;
    private Vector3 velocity = Vector3.zero;


    //Camera Position Offset
    public float xOffset;
    public float yOffset;
    

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        isFollowing = true;
    }

    void Update()
    {
        if(isFollowing){
            // update target vector
            target = new Vector3(player.transform.position.x + xOffset, player.transform.position.y+yOffset, transform.position.z);
            // move toward target
            transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smoothTime);
        }
    }
}
