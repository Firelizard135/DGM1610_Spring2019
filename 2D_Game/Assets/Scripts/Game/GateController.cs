using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public Animator animator;

    void Start(){
        animator.SetBool("isOpen",false);
    }

    // Open the gate
    public void OpenGate(){
        animator.SetBool("isOpen",true);
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
