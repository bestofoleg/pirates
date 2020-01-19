using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public int forwardspeedsail;
    public float moveSpeed;
   public Animator anim;
    public float rotateSpeed;

    public Rigidbody shipRigidbody;

    public Transform characterTransform;

    public Transform targetPoint;
    
    private void FixedUpdate()
    {
        anim = GetComponent<Animator>();
    }
   
    public void rotateShip(float scale)
    {
        transform.Rotate(Vector3.up * scale * rotateSpeed * Time.deltaTime);
    }

    private void Update()
    {
        if (forwardspeedsail == 1)
        {
            shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
        }
        if (forwardspeedsail >= 2)
        {
            shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime * 2);
        }
        if (forwardspeedsail == 0)
        {
            shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * 0 * Time.deltaTime);
        }

        if (forwardspeedsail < 0)
        {
            forwardspeedsail = 0;
        }
        if (forwardspeedsail > 2)
        {
            forwardspeedsail = 2;
        }
        characterTransform.position = targetPoint.position;
        characterTransform.rotation = transform.rotation;
    }
}
