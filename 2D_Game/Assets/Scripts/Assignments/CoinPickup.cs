using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : GenericPickup {

    public GameObject PC;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "Player"){
            //player collects coin
            print("you've collected a coin");
            Destroy(gameObject);
        }
        else {
            //not player
        }
    }

}
