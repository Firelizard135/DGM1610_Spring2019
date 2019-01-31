using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Variables
    public int number;
    public float speed;
    public string name;

    // Start is called before the first frame update
    void Start()
    {
        /*
        This
        is 
        a 
        multi-line
        comment.
         */
        // number = 5;
        speed = 0.94f;
        name = "Micah";

        print(name + " is " + number + " years old.");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(number,0,0);
    }
}
