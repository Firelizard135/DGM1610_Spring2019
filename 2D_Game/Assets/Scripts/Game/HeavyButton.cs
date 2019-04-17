using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyButton : MonoBehaviour
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
        // If colliding object is heavier than 1.5
        if(GameObject.Find(other.name).GetComponent<Rigidbody2D>().mass >= 1.5 ){
            animator.SetBool("isDown",true);
            GetComponent<BoxCollider2D>().enabled = false;

            gateController.OpenGate();
        }
    }
}