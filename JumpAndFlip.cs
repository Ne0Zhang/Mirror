using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndFlip : MonoBehaviour
{
    public bool VisibleIniatially;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = VisibleIniatially;
        gameObject.GetComponent<Collider>().enabled = VisibleIniatially;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Player Jumped");
            VisibleIniatially = !VisibleIniatially;
            gameObject.GetComponent<Renderer>().enabled = VisibleIniatially;
            gameObject.GetComponent<Collider>().enabled = VisibleIniatially;
            
        }
    }
}
