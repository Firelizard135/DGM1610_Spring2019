using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject levelManager;
    private LevelManager levelManagerScript;

    void Start() {
        levelManagerScript = levelManager.GetComponent<LevelManager>();
    }

    // Hits checkpoint
    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "Player") {
            levelManagerScript.currentCheckPoint = gameObject;
        }
    }
}
