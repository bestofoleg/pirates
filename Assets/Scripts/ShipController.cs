using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float moveSpeed;

    public float rotateSpeed;

    public Rigidbody shipRigidbody;

    public Transform characterTransform;

    public Transform targetPoint;
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
        }
    }

    public void rotateShip(float scale)
    {
        transform.Rotate(Vector3.up * scale * rotateSpeed * Time.deltaTime);
    }

    private void Update()
    {
        characterTransform.position = targetPoint.position;
        characterTransform.rotation = transform.rotation;
    }
}
