using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script checks the direction string and moves game object in that direction */

public class Moving : MonoBehaviour
{
    //variables
    public string direction;
    public float xspeed;
    public float yspeed;
    private float xpos;
    private float ypos;
    // Start is called before the first frame update
    void Start()
    {
        Movement(direction);
    }

    void Movement(string move_direction) {
        if(move_direction == "up") {
            yspeed = 0.05f;
        }
        else if(move_direction == "down") {
            yspeed = -0.05f;
        }
        else if(move_direction == "left") {
            xspeed = -0.05f;
        }
        else if(move_direction == "right") {
            xspeed = 0.05f;
        }
        else {
            print("unknown direction: "+move_direction);
        }
    }
    void FixedUpdate()
    {
        xpos = xpos+xspeed;
        ypos = ypos+yspeed;
        transform.position = new Vector3(xpos,ypos,0);
    }
}
