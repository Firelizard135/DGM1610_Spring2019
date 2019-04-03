using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    private Text healthText;

    private PlayerController playerController;
    private GameObject player;

    public LevelManager levelManager;
    
    void Start()
    {
        healthText = GetComponent<Text>();

        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        player = GameObject.Find("Player");

        levelManager = FindObjectOfType<LevelManager>();

        //set health to full
        playerController.healthNow = playerController.maxHealth;
    }

    // when player takes damage
    public void PlayerHurt(int amount)
    {
        print("You've taken damage");
        //subtract health
        playerController.healthNow -= amount;
        // Update health display
        healthText.text = playerController.healthNow+"/"+playerController.maxHealth;
        // if dead, respawn
        if(playerController.healthNow <= 0){
            levelManager.RespawnPlayer();
        }
    }

    //
    public void PlayerHeal(int amount)
    {
        print("You've recovered health");
        //add health
        playerController.healthNow += amount;
        // Update health display
        healthText.text = playerController.healthNow+"/"+playerController.maxHealth;
    }
}

