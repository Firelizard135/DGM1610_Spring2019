using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour{

    public string suspect;


    void Start() {
        MurderMystery(suspect);
    }

    
    void MurderMystery (string person) {
        switch(person) {

            case "Mr. Ketchup":
            case "Mr. Radish":
                print("I was in the billiard room drinking tea with Mr. Ketchup.");
            break;
            case "Ms. Frysauce":
                print("I was talking on the rotary phone with my mother, Mrs. Mayo.");
            break;
            case "Mrs. Mayo":
                print("I was in the kitchen cleaning the dishes.");
            break;
            default:
                print("I am not familiar with "+suspect+" .");
            break;
        }
    }
}


