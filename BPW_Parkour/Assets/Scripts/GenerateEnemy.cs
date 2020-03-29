using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour

{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 2)
        {
            xPos = Random.Range(-40, -47);
            zPos = Random.Range(2, 9);
            Instantiate(enemy, new Vector3(xPos,6f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.5f);
            enemyCount += 1;



        }
    }
}