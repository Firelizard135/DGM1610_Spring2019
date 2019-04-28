using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    //Player Scripts
    private GameObject player;
    private PlayerController playerController;
    private PlayerShoot playerShoot;

    public LayerMask whatIsEnemy;

    public HealthManager healthManager;

    public GameObject sparksParticle;

    public int lifeSpan;
    public int damageAmount;
    public float speed;
    private float direction;
    private float speedX;
    private float speedY;
    private float distanceX;
    private float distanceY;


    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
        player = GameObject.Find("Player");

        distanceX = transform.position.x - player.transform.position.x;
        distanceY = transform.position.y - player.transform.position.y;

        speedX = -distanceX / 15;
        speedY = -distanceY / 15;

        //Start timer till self destruct
        StartCoroutine("DestroyTimer");
    }

    void FixedUpdate()
    {

        //Move
        transform.position = new Vector2(transform.position.x+speedX*speed,transform.position.y+speedY*speed);
    }

    // When the projectile hits something
    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Player"){
            healthManager.PlayerHurt(damageAmount);
        }
        if(other.name != "Enemy"){
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
