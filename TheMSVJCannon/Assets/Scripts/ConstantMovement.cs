using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed = 5.0f;

    private void Update()
    {
        transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;
    }
}
