using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    private Text healthText;

    PlayerController playerController;

    
    void Start()
    {
        healthText = GetComponent<Text>();

        playerController = GetComponent<PlayerController>();

        playerController.healthNow = playerController.maxHealth;
    }

    
    void Update()
    {

        if (playerController.healthNow < 0)
            playerController.healthNow = 0;

        healthText.text = playerController.healthNow+"/"+playerController.maxHealth;
    }
}

