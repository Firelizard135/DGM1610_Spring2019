using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{

    public static int coinCount;

    private Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<Text>();

        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (coinCount < 0)
            coinCount = 0;

        coinText.text = " " + coinCount;
    }

    public static void AddPoints (int pointsToAdd) {
        coinCount += pointsToAdd;
    }
}
