using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public float rotSpeed = 10;
    public float moveSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        ForwardMovement();
        Turning();
        Actions();
    }

    private void ForwardMovement()
    {
        bool isWalking = Input.GetKey("w");
        bool isBacking = Input.GetKey("s");
        bool isRunning = isWalking && Input.GetKey("left shift");
        bool isBRunning = isBacking && Input.GetKey("left shift");

       // Debug.Log("Walking: " + isWalking);
       //  Debug.Log("Running: " + isRunning);

        anim.SetBool("Walking", isWalking);
        anim.SetBool("Running", isRunning);

        if (isWalking)
        {
            float speed = isRunning ? moveSpeed * 2 : moveSpeed;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (isBacking)
        {
            float speed = isBRunning ? moveSpeed * 2 : moveSpeed;
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }

    private void Turning()
    {
        bool turnLeft = Input.GetKey("a");
        bool turnRight = Input.GetKey("d");

        if (turnLeft)
        {
            transform.Rotate(0, -rotSpeed * Time.deltaTime, 0, Space.World);
        }
        if (turnRight)
        {
            transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
        }

        anim.SetBool("Turn Left", turnLeft);
        anim.SetBool("Turn Right", turnRight);
    }

    private void Actions()
    {
        if (Input.GetKeyDown("e"))
        {
            anim.SetBool("Waving", true);
        }
        else if (Input.GetKeyUp("e"))
        {
            anim.SetBool("Waving", false);
        }
    }


}
