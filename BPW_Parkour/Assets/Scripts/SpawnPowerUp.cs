using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    public GameObject Powerup;
    public int xPos;
    public int zPos;
    public int PowerUpCount;
    void Start()
    {
        StartCoroutine(PowerUpDrop());
    }
    IEnumerator PowerUpDrop()
    {
        while (PowerUpCount < 1)
        {
            xPos = Random.Range(-60, -140);
            zPos = Random.Range(2, 9);
            Instantiate(Powerup, new Vector3(xPos, 6f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.5f);
            PowerUpCount += 1;



        }
    }
}