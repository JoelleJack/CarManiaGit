using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public float multiplier = 1.5f;
    public float time = 10;

   

    void OnTriggerEnter(Collider other)

    {
       
        if(other.CompareTag("Player"))
        {
           StartCoroutine( Pickup(other));
        }
    }
 IEnumerator Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerMovement movement = player.GetComponent<PlayerMovement>();

        movement.moveSpeed *= multiplier;

        yield return new WaitForSeconds(time);

        movement.moveSpeed /= multiplier;


        Destroy (gameObject);
        Debug.Log("Je doet het goed!");
    }
}