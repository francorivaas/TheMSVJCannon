using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 movement;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Physics.gravity += new Vector3(0f, -1.0f, 0f);

        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");

        movement = new Vector3(movementX, 0f, movementY);
        movement = movement * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
