using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    private Text healthText;

    private PlayerController playerController;
    private GameObject player;
    private Rigidbody2D pcRigid;

    public GameObject healthParticle;

    public LevelManager levelManager;
    
    void Start()
    {
        healthText = GetComponent<Text>();

        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
        pcRigid = player.GetComponent<Rigidbody2D>();

        levelManager = FindObjectOfType<LevelManager>();

        //set health to full
        playerController.healthNow = playerController.maxHealth;
        // Update health display
        healthText.text = playerController.healthNow+"/"+playerController.maxHealth;
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
        //generate death particle
        Instantiate(healthParticle, pcRigid.transform.position, pcRigid.transform.rotation);
    }
}

