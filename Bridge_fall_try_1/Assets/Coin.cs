using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(100 * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="MainPlayer")
        {
            PlayerManager.numberOfCoins += 87;
            Destroy(gameObject);
        }
    }
}
