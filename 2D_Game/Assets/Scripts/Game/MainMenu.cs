using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Indexed level to load
    public int levelToLoad;

    // This function loads the indexed level stored in the levelToLoad variable
    public void LoadLevel(){
        SceneManager.LoadScene(levelToLoad);
    }
    // This function exits the game
    public void LevelExit(){
        Application.Quit();
    }


}
