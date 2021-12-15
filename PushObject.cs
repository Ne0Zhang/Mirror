using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
    private CharacterController controller;
    float force = 5;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit (ControllerColliderHit hit) {
        Rigidbody box = hit.collider.attachedRigidbody;

        if (box != null && controller.isGrounded) {
            Vector3 moveDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
            box.velocity = moveDir * force;

        }
    }
}
