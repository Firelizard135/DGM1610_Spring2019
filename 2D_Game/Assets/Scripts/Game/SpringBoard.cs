using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBoard : MonoBehaviour
{
    public Animator animator;
    public float springForce;

    void Start(){
        animator.SetBool("isTriggered",false);
    }

    // Press Button
    void OnTriggerEnter2D(Collider2D other) {
        animator.SetBool("isTriggered",true);
        other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x, 0);
        other.GetComponent<Rigidbody2D>().AddForce(transform.up*springForce*100);
    }
    void OnTriggerExit2D(Collider2D other) {
        animator.SetBool("isTriggered",false);
    }
}
