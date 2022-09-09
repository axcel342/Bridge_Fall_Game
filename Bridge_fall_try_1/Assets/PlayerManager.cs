using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static int numberOfCoins;
    public TextMeshProUGUI scoreTest;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTest.text = "Score:" + numberOfCoins;
    }

}
