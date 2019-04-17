using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Goes on player object

public class PlayerShoot : MonoBehaviour
{
    //Define Projectile
    public GameObject projectile;

    public float maxShotCharge;
    public float shotChargeSpeed;
    private float shotCharge;

    private Rigidbody2D rb2D;
    public GameObject sparksParticle;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Shoot
        if(Input.GetButton("Fire1") && shotCharge<maxShotCharge) {
            shotCharge += shotChargeSpeed;
        }
        if(Input.GetButtonUp("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(projectile, rb2D.transform.position, rb2D.transform.rotation);
        Instantiate(sparksParticle, rb2D.transform.position, rb2D.transform.rotation);
        shotCharge = 0;
    }
}
