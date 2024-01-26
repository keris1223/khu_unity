using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    PlayerPositionChange playerMovement;

   private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerPositionChange>();
   }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            
            playerMovement.Die();
        }
    }

    private void Update () {
   
   }
}