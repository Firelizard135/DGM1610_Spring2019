using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{

    public float speed;

    public float timeOut;
    public GameObject player;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;

        projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

        if(player.transform.localScale.x < 0)
            speed = -speed;


        Destroy(gameObject,timeOut);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other) {
        //Destroys enemies on contact with projectiles. Adds points.
        if(other.tag == "Enemy") {
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            CoinCounter.AddPoints(pointsForKill);
        }

        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other) {
        //Destroys enemies on contact with projectiles. Adds points.
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
