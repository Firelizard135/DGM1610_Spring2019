using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private PlayerController playerController;
    public float speed;
    private float direction;
    public int lifeSpan;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        direction = playerController.direction;

        //Start timer till self destruct
        StartCoroutine("DestroyTimer");
    }

    void FixedUpdate()
    {
        //Move Horizontally
        transform.position = new Vector2(transform.position.x+speed*Mathf.Sign(direction),transform.position.y);
    }

    // When the projectile hits something
    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Enemy"){
            Destroy(GameObject.Find("Enemy"));
        }
        if(other.name != "Player"){
            Destroy(gameObject);
        }
    }

    // Destroy self after timer finishes
    public IEnumerator DestroyTimer(){ 
        yield return new WaitForSeconds (lifeSpan);
        Destroy(gameObject);
    }
}
