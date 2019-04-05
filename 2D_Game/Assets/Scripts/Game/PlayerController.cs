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
    private int jumpHeightNow; // How long the jump key has been held down
    public int jumpsMax;
    public float jumpForce;
    public int jumpHeightMax;

    //Define Projectile
    public GameObject projectile;


    void Start()
    {
        
    }

    void FixedUpdate() {
        // check if grounded
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if(grounded) {
            // resets jump
            jumpsLeft = jumpsMax;
            jumpHeightNow = 0;
        }
    }

    
    void Update()
    {
        // Horizontal Movement
        if(Input.GetAxis("Horizontal") != 0) {
            direction = Input.GetAxis("Horizontal");

            GetComponent<Rigidbody2D>().velocity = new Vector2(direction*moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        // Variable Height Jump
        if(Input.GetKeyDown(KeyCode.W) && jumpsLeft>0 && jumpHeightNow<jumpHeightMax) {
            jumpHeightNow += 1;
            Jump();
        }
        if(Input.GetKeyUp(KeyCode.W)) {
            jumpsLeft -= 1;
            if(jumpsLeft>0) {
                jumpHeightNow = 0; //reset jump height limit
            }
            else {
                jumpHeightNow = jumpHeightMax; //Jumps are done
            }
        }

        //Shoot
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
        }

    }

    void Jump() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
    }

    void Shoot() {
        Instantiate(projectile, GetComponent<Rigidbody2D>().transform.position, GetComponent<Rigidbody2D>().transform.rotation);
    }

}
