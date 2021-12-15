using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Player;
    
    void OnTriggerEnter (Collider other) 
    {
        PlayerTeleport();
    }
    
    void PlayerTeleport() 
    {
        Debug.Log("Teleport!");
        Player.transform.position = Portal.transform.GetChild(0).position;
    }
}
