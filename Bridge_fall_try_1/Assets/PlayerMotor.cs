using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    // Start is called before the first frame update

    public float speed = 5.0f;
    private Vector3 moveVector;
    private Vector3 turnVector;
    


    void Start()
    {
        controller = GetComponent<CharacterController>();
        turnVector.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //moveVector = moveVector = Vector3.zero;
        controller.Move(Vector3.forward * speed * Time.deltaTime  );

        Movement();
    }

    void Movement()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            
            turnVector.y = 0;
            // transform.position = touch.position;

            if (touch.position.x < (float)(Screen.width / 2.0f))
            {
                
                turnVector.x = touchPosition.x;
                turnVector.z = speed;
                //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
                controller.Move(turnVector * Time.deltaTime * speed);
                print("Right press");
            }

            if (touch.position.x > (float)(Screen.width / 2.0f))
            {
                turnVector.x = touchPosition.x;
                controller.Move(Vector3.left * Time.deltaTime * speed);
                //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
                print("Left press");
            }

            print(touch.position.x);
        }
    }
}
