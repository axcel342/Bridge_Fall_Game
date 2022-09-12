using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public PlayerMotor playerMotor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            playerMotor.anim.SetFloat("vertical", 0f);
            playerMotor.anim.SetFloat("horizontal", 0f);
            playerMotor.enabled = false;
            print("Entered playerhit");
        }

        if (other.tag == "Finish_Line")
        {
            
            playerMotor.anim.SetFloat("vertical", 0f);
            playerMotor.anim.SetFloat("horizontal", 0f);
            playerMotor.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            print("Reached Finish Line");
        }

        if(other.tag == "Ground")
        {
            print("left ground");
            FindObjectOfType<GameManager>().RetryScreen();
        }

        if(other.tag == "base")
        {
            print("hit base");
            FindObjectOfType<GameManager>().RetryScreen();
        }

        //else
        //{
        //    print("not on ground");
        //}
    }
}
