using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Health
    public int maxHealth;
    public int healthNow;

    // Player Movement Variables
    public float moveSpeed;
    public float direction;

    // Player grounded variables
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    // Jumping
    private int jumpsLeft; // how many jumps left
    public int jumpsMax;
    public float jumpForce;

    private float scale;
    private Rigidbody2D rb2D;

    public Animator animator;

    public float greaterMass;
    public float lesserMass;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        animator.SetBool("isHeavy",false);

        rb2D.mass = lesserMass;

        scale = transform.localScale.x;
    }

    void FixedUpdate() {
        // check if grounded
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if(grounded) {
            // resets jump
            jumpsLeft = jumpsMax;
        }
    }

    
    void Update()
    {
        // Horizontal Movement
        if(Input.GetAxis("Horizontal") != 0) {
            direction = Input.GetAxis("Horizontal");

            rb2D.velocity = new Vector2(direction*moveSpeed/rb2D.mass, rb2D.velocity.y);
            //rb2D.AddForce(transform.right*direction*moveSpeed);
        }

        //Player Flip
        transform.localScale = new Vector3(Mathf.Sign(-direction)*scale,scale,1f);


        // Variable Height Jump
        if(Input.GetKeyDown(KeyCode.W) && jumpsLeft>0) {
            Jump();
        }
        if(Input.GetKeyUp(KeyCode.W)) {
            jumpsLeft -= 1;
            if(rb2D.velocity.y > 0){
                rb2D.velocity = new Vector2(rb2D.velocity.x, rb2D.velocity.y * 0.5f);
            }
        }


        //Toggle weight
        if(Input.GetButtonDown("Fire3")) {
            ToggleMass();
        }

    }


    void Jump() {
        //rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        rb2D.AddForce(transform.up * jumpForce * 10);
    }

    void ToggleMass() {
        if(animator.GetBool("isHeavy") == true) {
            rb2D.mass = lesserMass;
            animator.SetBool("isHeavy",false);
        }
        else {
            rb2D.mass = greaterMass;
            animator.SetBool("isHeavy",true);
        }
    }
}
