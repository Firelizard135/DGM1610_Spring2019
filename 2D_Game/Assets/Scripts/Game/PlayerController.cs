using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Player Movement Variables
    public float moveSpeed;
    private float direction;
    public float jumpForce;
    public int jumpHeightMax;

    // Player grounded variables
    private bool grounded;
    private bool canJump;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    // How long the jump key has been held down
    private int jumpHeightNow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() {
        // check if grounded
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if(grounded) {
            // resets jump
            canJump = true;
            jumpHeightNow = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        if(Input.GetAxis("Horizontal") != 0) {
            direction = Input.GetAxis("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(direction*moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        // Left Right Movement
        // if(Input.GetKey(KeyCode.D)) {
        //     GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        // }
        // else if(Input.GetKey(KeyCode.A)) {
        //     GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        // }


        // Variable Jump
        if(Input.GetKey(KeyCode.W) && canJump && jumpHeightNow<jumpHeightMax) {
            jumpHeightNow += 1;
            Jump();
        }
        if(Input.GetKeyUp(KeyCode.W)) {
            jumpHeightNow = jumpHeightMax;
            canJump = false;
        }

    }

    void Jump() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
    }

}
