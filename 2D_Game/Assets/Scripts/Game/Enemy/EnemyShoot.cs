using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject player;
    public LayerMask whatIsPlayer;

    //Define Projectile
    public GameObject projectile;
    public GameObject sparksParticle;

    public Transform shootCheck;

    private Collider2D playerCollider;
    private Collider2D collider;

    public float shotRange;
    public float shotDelay;
    private bool playerInRange;
    private bool canShoot;

    void Start()
    {
        playerCollider = player.GetComponent<Collider2D>();
        collider = GetComponent<Collider2D>();
        canShoot = true;
    }

    void Update()
    {
        playerInRange = Physics2D.OverlapCircle(shootCheck.position, shotRange, whatIsPlayer);

        if(playerInRange & canShoot) {
            Shoot();
        }
    }

    void Shoot()
    {
        StartCoroutine("ShootPlayer");
        canShoot = false;
    }

    public IEnumerator ShootPlayer(){
        // Shoot
        Instantiate(projectile, transform.position, transform.rotation);
        Instantiate(sparksParticle, transform.position, transform.rotation);

        yield return new WaitForSeconds (shotDelay);
        canShoot = true;
    }
}

