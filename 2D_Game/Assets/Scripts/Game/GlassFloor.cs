using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFloor : MonoBehaviour
{
    public GameObject glassParticle;
    public int weight;

    void Start(){

    }

    // Floor break
    void OnCollisionEnter2D(Collision2D other) {
        // If colliding object is heavier than weight
        if(other.gameObject.GetComponent<Rigidbody2D>().mass >= weight ){
            Instantiate(glassParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
