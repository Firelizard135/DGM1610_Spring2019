using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Player Scripts
    private PlayerController playerController;
    private PlayerShoot playerShoot;

    public GameObject sparksParticle;

    public int lifeSpan;
    public float speed;
    private float direction;
    private float charge;
    

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        playerShoot = GameObject.Find("Player").GetComponent<PlayerShoot>();
        direction = playerController.direction;

        charge = playerShoot.shotCharge/2;
        playerShoot.shotCharge = 0;

        //Start timer till self destruct
        StartCoroutine("DestroyTimer");
    }

    void FixedUpdate()
    {
        //Move Horizontally
        transform.position = new Vector2(transform.position.x+speed*Mathf.Sign(direction)*charge,transform.position.y);
    }

    // When the projectile hits something
    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Enemy"){
            Destroy(GameObject.Find("Enemy"));
        }
        if(other.name != "Player"){
            Destroy(gameObject);
            Instantiate(sparksParticle, transform.position, transform.rotation);
        }
    }

    // Destroy self after timer finishes
    public IEnumerator DestroyTimer(){ 
        yield return new WaitForSeconds (lifeSpan);
        Destroy(gameObject);
    }
}
