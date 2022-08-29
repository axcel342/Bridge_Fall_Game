using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitObstacle : MonoBehaviour
{

    public PlayerMotor playerMotor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {


            playerMotor.enabled = false;
            print("Obstacle hit bot");
        }
    }
}
