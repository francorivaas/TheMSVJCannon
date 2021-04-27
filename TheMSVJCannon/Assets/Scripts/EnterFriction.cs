using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFriction : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public bool gravityOn;

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gravityOn && collision.gameObject.CompareTag("Player"))
        {
            var body = player.GetComponent<Rigidbody>();
            body.useGravity = false;
            body.AddForce(transform.position + Vector3.up * 150.0f);
        }

        else if (!gravityOn)
        {
            player.GetComponent<Rigidbody>().useGravity = true;
            
            
        }
            
    }
}
