using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public PlayerController player;

    public bool isFollowing;

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
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y+yOffset, transform.position.z);
        }
    }
}
