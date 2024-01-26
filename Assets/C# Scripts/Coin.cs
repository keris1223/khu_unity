
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private float turnSpeed = 90f;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null) {
            Destroy(gameObject);
            return;
        }

        if (other.gameObject.name != "Player") {
            Destroy(gameObject);
            return;
        }
        
    }

    private void Start () {

   }

   private void Update () {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);

   }
}