using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    public int levelToLoad;
    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "Player"){
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
