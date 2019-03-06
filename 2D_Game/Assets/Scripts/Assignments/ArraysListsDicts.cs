using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListDicts : MonoBehaviour
{

    public string client1 = "Greg";
    public string client2 = "Katie";
    public string client3 = "Adam";
    public string client4 = "Mia";
    public string client5 = "Fred"; 

    // Array Example
    public string[] clientList = new string[]{"Greg","Katie","Adam","Mia","Fred"};

    // List Example
    public List<string> santasList = new List<string>();

    // ArrayList Example
    public ArrayList inventory = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        santasList.Add("Jimmy");
        santasList.Add("Jenny");
        santasList.Add("Sam");
        santasList.Add("Ty");
        santasList.Add("Susie");
        santasList.Add("Jimmy");

        print(clientList[2]);

        print(santasList[3]);

        inventory.Add(10);
        inventory.Add("Bob");
        inventory.Add(true);
        inventory.Add(5.23);

        print(inventory[2]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
