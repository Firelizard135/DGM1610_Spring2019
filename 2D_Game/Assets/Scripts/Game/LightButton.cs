using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{
    public Animator animator;

    public GameObject gate;
    private GateController gateController;

    void Start(){
        animator.SetBool("isDown",false);

        gateController = gate.GetComponent<GateController>();
    }

    // Press Button
    void OnTriggerEnter2D(Collider2D other) {
        animator.SetBool("isDown",true);
        GetComponent<BoxCollider2D>().enabled = false;

        gateController.OpenGate();
    }
}