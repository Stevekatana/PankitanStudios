using System.IO.Compression;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    // public float gravity = -9.81f;
    // Vector3 velocity;
    // public Transform groundCheck;
    // public float groundDistance = 0.4f;
    // public LayerMask groundMask;
    // bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        // isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        // if (isGrounded && velocity.y < 0)
        // {
        //     velocity.y = -2f;
        // }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

         Vector3 move = transform.right * x + transform.forward * z;
         controller.Move(move * speed * Time.deltaTime);
        // velocity.y += gravity * Time.deltaTime;
        // controller.Move(velocity*Time.deltaTime);
    }
}
