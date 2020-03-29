using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2generateNewEnemyCar : MonoBehaviour
{
   
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    void Start()
    {
        

    }


    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(EnemyDrop());
        IEnumerator EnemyDrop()
        {
            while (enemyCount < 2)
            {
                xPos = Random.Range(-290, -325);
                zPos = Random.Range(2, 11);
                Instantiate(enemy, new Vector3(xPos, 6.1f, zPos), Quaternion.identity);

                yield return new WaitForSeconds(3.1f);
                enemyCount += 1;



            }
        }
    }
}
    