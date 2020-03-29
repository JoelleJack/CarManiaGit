using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : MonoBehaviour
{
    public GameObject pickupEffect;
    public float multiplier = 1.3f;
    public float time = 10;


   
    

   
    void OnTriggerEnter(Collider other)

    {

       

        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        PlayerMovement movement = player.GetComponent<PlayerMovement>();

        movement.jumpVelocity *= multiplier;

        yield return new WaitForSeconds(time);

        movement.jumpVelocity /= multiplier;


        Destroy(gameObject);
        Debug.Log("Je doet het goed!");
    }
}