using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    private Rigidbody rb;
    private bool IsGrounded;
    public float grav;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (!IsGrounded) {
            Physics.gravity = new Vector3 (0, -grav, 0);
        }
    }
    void OnCollisionEnter(Collision other) {
        Debug.Log("Is Grounded");
        IsGrounded = true;

    }
    void OnCollisionExit(Collision other) {
        Debug.Log("Not Grounded");
        IsGrounded = false;
    }
}
