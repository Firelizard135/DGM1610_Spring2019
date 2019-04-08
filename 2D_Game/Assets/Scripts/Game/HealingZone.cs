using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingZone : MonoBehaviour
{
    public HealthManager healthManager;
    private int healAmount;

    private PlayerController playerController;

    void Start () {
        healthManager = FindObjectOfType<HealthManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Player"){
            healthManager.PlayerHeal(playerController.maxHealth - playerController.healthNow);
        }
    }
}
