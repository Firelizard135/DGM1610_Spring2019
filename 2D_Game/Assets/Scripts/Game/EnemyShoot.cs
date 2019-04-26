using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject player;
    private Collider2D playerCollider;

    private Collider2D collider;

    public float range;
    public float shotDelay;
    private float playerDistance;
    private bool canShoot;

    void Start()
    {
        playerCollider = player.GetComponent<Collider2D>();
        collider = GetComponent<Collider2D>();
        canShoot = true;
    }

    void Update()
    {
        playerDistance = Vector2.Distance(player.transform.position, transform.position);

        if(playerDistance < range) 
            if(canShoot == true) {
                Shoot();
            }
    }

    void Shoot()
    {
        StartCoroutine("ShootPlayer");
        canShoot = false;
    }

    public IEnumerator ShootPlayer(){
        print("enemy shoot");
        yield return new WaitForSeconds (shotDelay);
        canShoot = true;
    }
}

