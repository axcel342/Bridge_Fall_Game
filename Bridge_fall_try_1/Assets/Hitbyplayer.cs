using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbyplayer : MonoBehaviour
{
    public PlayerMotor playerMotor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainPlayer")
        {
            
            this.gameObject.tag = other.tag;
            // hit.trying = other.gameObject;
            playerMotor.enabled = true;
            print("Player hit");

            this.enabled = false;
        }
    }

}
