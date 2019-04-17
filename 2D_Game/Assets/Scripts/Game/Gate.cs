using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public Animator animator;

    void Start(){
        animator.SetBool("isOpen",false);
    }

    public void OpenGate(){
        animator.SetBool("isOpen",true);
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
