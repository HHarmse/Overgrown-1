using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float _speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (GameManager.instance.canMovePlayer)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * _speed , 0 , Input.GetAxis("Vertical") * _speed);
        }
    }
}
