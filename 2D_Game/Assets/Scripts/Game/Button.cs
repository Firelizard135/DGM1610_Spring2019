using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public bool isHeavy;
    private bool isPressed;

    void Start(){
        isPressed = false;
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        isPressed = true;
        
        GetComponent<BoxCollider2D>().enabled = false;
    }
}