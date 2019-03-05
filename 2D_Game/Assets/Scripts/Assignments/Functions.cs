using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string weather;
    void Start(){
        Weather(weather);
    }
    void Weather(string weatherState){
        if(weatherState == "Sunny") {
            print("The sun is a deadly laser");
        }
        else if (weatherState == "Raining") {
            print("Its raining somewhere else");
        }
        else if (weatherState == "Windy") {
            print("Its very windy today");
        }
        else if (weatherState == "Snowy") {
            print("Its a blizzard out there");
        }
        else if (weatherState == "Raining") {
            print("Its raining cats and dogs");
        }
        else {
            print("I dont understand "+weatherState);
        }
    }


}
