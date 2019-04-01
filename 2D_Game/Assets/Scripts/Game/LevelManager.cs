using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;
    private Rigidbody2D pcRigid;

    private GameObject player;

    //Particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    //Respawn Delay
    public float respawnDelay;


    //Point Penalty on Death
    public int pointPenaltyOnDeath;

    //Store Gravity Value
    private float gravityStore;


    // Start is called before the first frame update
    void Start()
    {
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    public void RespawnPlayer() {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo(){
        //generate death particle
        Instantiate(deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
        //Hide PC
        player.SetActive(false);
        pcRigid.GetComponent<Renderer> ().enabled = false;
        //gravity reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //point penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        // debug message
        Debug.Log("PC Respawn");
        //respawn delay
        yield return new WaitForSeconds (respawnDelay);
        //gravity restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //match PCs transform position
        pcRigid.transform.position = currentCheckPoint.transform.position;
        //show pc
        player.SetActive(true);
        pcRigid.GetComponent<Renderer>().enabled = true;
        //spawn PC
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
