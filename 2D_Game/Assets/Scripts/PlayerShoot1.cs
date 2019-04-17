using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot1 : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        // Load projectile from Resources/Prfabs Folder
        projectile = Resources.Load("Prefabs/Projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
        }
    }
}
