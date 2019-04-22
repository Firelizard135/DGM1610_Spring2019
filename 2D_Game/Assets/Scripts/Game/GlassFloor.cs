using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFloor : MonoBehaviour
{
    public GameObject glassParticle;

    void Start(){

    }

    // Floor break
    void OnCollisionEnter2D(Collision2D other) {
        // If colliding object is heavier than 1.5
        if(other.gameObject.GetComponent<Rigidbody2D>().mass >= 1.5 ){
            Instantiate(glassParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
