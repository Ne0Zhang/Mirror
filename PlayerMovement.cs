using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Rigidbody rb;
    private float directionY;
    
    float moveSpeed = 10f;
    float gravity = 9.81f;
    float jumpSpeed = 2.3f;

    void Start() 
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);
        
        if (controller.isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                directionY = jumpSpeed;
            }
            else {
                directionY = -1f;
            }
        }

        if (!controller.isGrounded) {
            moveSpeed = 5.5F;
        } else {
            moveSpeed = 10F;
        }


        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        controller.Move(direction * moveSpeed * Time.deltaTime);
    }
}
