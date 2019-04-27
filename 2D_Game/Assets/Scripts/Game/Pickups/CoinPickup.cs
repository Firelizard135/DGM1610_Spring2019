using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : GenericPickup {

    public int coinValue;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "Player"){
            //player collects coin
            print("you've collected a coin");

            CoinCounter.AddPoints(coinValue);

            Destroy(gameObject);
        }
    }

}
