using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movements : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 50f;
    public Transform player;
    public Vector3 moveX;
    public Vector3 moveZ;

    public Joystick joystick;


    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey("d"))
        // {
        //     player.position += moveX;
        // }
        // if(Input.GetKey("a"))
        // {
        //     player.position -= moveX;
        // }
        // if(Input.GetKey("w"))
        // {
        //     player.position += moveZ;
        // }
        // if(Input.GetKey("s"))
        // {
        //     player.position -= moveZ;
        // }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        float horizontalMove = joystick.Horizontal * force;
        float verticalMove = joystick.Vertical * force;

        if (horizontalMove != 0)
        {
            rb.AddForce(horizontalMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (verticalMove != 0)
        {
            rb.AddForce(0, 0, verticalMove * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
