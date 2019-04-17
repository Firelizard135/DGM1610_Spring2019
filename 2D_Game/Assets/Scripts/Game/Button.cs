using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animator;

    public GameObject gate;
    private Gate gateScript;

    void Start(){
        animator.SetBool("isDown",false);

        gate = GameObject.Find("Gate");
        gateScript = gate.GetComponent<Gate>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        animator.SetBool("isDown",true);
        GetComponent<BoxCollider2D>().enabled = false;

        gateScript.OpenGate();
    }
}