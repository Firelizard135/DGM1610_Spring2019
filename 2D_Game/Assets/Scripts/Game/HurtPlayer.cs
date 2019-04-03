using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public HealthManager healthManager;
    public int damageAmount;

    void Start () {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Player"){
            healthManager.PlayerHurt(damageAmount);
        }
    }
}
