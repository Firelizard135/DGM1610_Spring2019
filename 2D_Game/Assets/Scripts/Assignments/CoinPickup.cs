using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : GenericPickup {

    public GameObject PC;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "PC"){
            //player collects coin
        }
        else {
            //not player
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
