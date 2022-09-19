using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    public DynamicJoystick variableJoystick;

    public Animator anim;

    public float forwardspeed = 10.0f;
    public float dragSpeed = 5.0f;
    public Vector3 moveVector;
    private float gravity = 12.0f;
    private float verticalVelocity = 0.0f;
    private bool check_if_falling = false;
    public bool Allow_Forward_Movement = true;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //print(Time.time);

        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = 0.0f;
            //print("notfalling");
        }

        else 
        {
            verticalVelocity -= gravity * Time.deltaTime;
            //print("falling");
            if (check_if_falling == false)
            {
                check_if_falling = true;
                //FindObjectOfType<GameManager>().EndGame();
                //print("failed game");

            }
        }


        Movement_With_moveVector();

        //Movement_3rd_try();

        moveVector.y = verticalVelocity;

        //Movement_With_moveVector();

        moveVector.z = forwardspeed;

        if (!Allow_Forward_Movement)
        {
            moveVector.z = 0.0f;
        }

        

        this.anim.SetFloat("vertical", moveVector.z);
        this.anim.SetFloat("horizontal", moveVector.x);


        controller.Move(moveVector *Time.fixedDeltaTime);


    }

    //void Movement()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
    //        touchPosition.z = 0f;

    //        turnVector.y = 0;
    //        // transform.position = touch.position;

    //        if (touch.position.x < (float)(Screen.width / 2.0f))
    //        {

    //            turnVector.x = touchPosition.x;
    //            turnVector.z = speed;
    //            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
    //            //controller.Move(turnVector * Time.deltaTime * speed);
    //            controller.Move(Vector3.right * Time.deltaTime * speed);
    //            print("Right press");
    //        }

    //        if (touch.position.x > (float)(Screen.width / 2.0f))
    //        {
    //            turnVector.x = touchPosition.x;
    //            controller.Move(Vector3.left * Time.deltaTime * speed);
    //            //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
    //            print("Left press");
    //        }

    //        print(touch.position.x);
    //    }
    //}

    void Movement_With_moveVector()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;


            //if (touch.position.x < (float)(Screen.width / 2.0f))
            //{


            //    moveVector.x = Vector3.right.x * dragSpeed;
            //    print("Left press");
            //}

            //if (touch.position.x > (float)(Screen.width / 2.0f))
            //{
            //    moveVector.x = Vector3.left.x * dragSpeed;

            //    print("Right press");
            //}

            moveVector = Vector3.left * variableJoystick.Horizontal * dragSpeed;

            

            //print(touch.position.x);
        }
    }

    void Movement_3rd_try()
    {
        for(int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);

            moveVector = Vector3.zero;

            if (controller.isGrounded)
            {
                verticalVelocity = 0.0f;
            }

            else
            {
                verticalVelocity -= gravity * Time.deltaTime;
            }

            moveVector.x = Input.touches[i].position.x * dragSpeed;

            moveVector.y = verticalVelocity;

            moveVector.z = dragSpeed;


            controller.Move(moveVector * Time.deltaTime);

        }
    }
}
