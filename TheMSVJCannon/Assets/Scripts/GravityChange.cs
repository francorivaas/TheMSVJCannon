using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    [SerializeField] private EnterFriction enterFrction;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Physics.gravity = new Vector3(0f, -50f, 0f);
            enterFrction.enabled = false;
            Debug.Log("la concha puta de tu mamá con down");
        }
    }
}
