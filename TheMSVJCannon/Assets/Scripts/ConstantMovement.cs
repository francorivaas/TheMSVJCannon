using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();    
    }

    private void Start()
    {
              
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(Vector3.forward * 20.0f);
        }
        
    }
    //private void Update()
    //{
    //    transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;        
    //}
}
