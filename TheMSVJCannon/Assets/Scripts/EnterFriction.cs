using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFriction : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public bool gravityOff;

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gravityOff && collision.gameObject.CompareTag("Player"))
        {
            var body = player.GetComponent<Rigidbody>();
            body.useGravity = false;
            body.AddForce(transform.position + Vector3.up * 150.0f);
        }

        else if (!gravityOff)
        {
            player.GetComponent<Rigidbody>().useGravity = true;
            
            
        }
            
    }
}
