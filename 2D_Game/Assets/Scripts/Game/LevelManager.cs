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

    // Update is called once per frame
    void Update()
    {
        
    }
}
