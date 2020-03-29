using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarConstantMove : MonoBehaviour
{
    public float moveSpeed = 3.5f;

    void FixedUpdate()
    {
        transform.position += transform.right  * Time.deltaTime * moveSpeed;
    }
}
