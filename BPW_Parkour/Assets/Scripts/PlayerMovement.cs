using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3.5f;
    private Rigidbody rigidbody;
    [Range(1, 50)]
    public float jumpVelocity;

    private void Awake()
    {
    
    rigidbody = GetComponentInChildren<Rigidbody>();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()

    {
        float vert = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        Vector3 moveDir = vert * transform.forward + hor * transform.right;

        rigidbody.MovePosition(transform.position + moveDir.normalized * Time.deltaTime * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
           

       
    }
}