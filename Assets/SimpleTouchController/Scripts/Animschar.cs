﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animschar : MonoBehaviour
{
    public GameObject FX;
    public GameObject weapon;
    SimpleTouchController touch;
    Rigidbody rig;
    Animator mainchar;
    SimpleTouchController root;
    Vector3 lastpos;
    private bool isAttack;
    public Sword sword;

    void Start()
    {

        sword.swordCollider.enabled = false;
        isAttack = false;
        touch = GetComponent<PlayerMoveController>().leftController;
        root = GetComponent<PlayerMoveController>().rightController;
        rig = GetComponent<Rigidbody>();
        mainchar = GetComponent<Animator>();
        mainchar.SetBool("Walk", false);
        mainchar.SetBool("Stayroot", false);
    }


    private void FixedUpdate()
    {
        if (touch.GetTouchPosition != Vector2.zero)
        {
            mainchar.SetBool("Walk", true);
        }
        else
        {
            mainchar.SetBool("Walk", false);
        }

        if (root.GetTouchPosition != Vector2.zero)
        {
            mainchar.SetBool("Stayroot", true);
        }
        else
        {
            mainchar.SetBool("Stayroot", false);
        }

        if (isAttack)
        {
            if (mainchar.GetCurrentAnimatorStateInfo(0).IsName("hightatackidle"))
            {
                sword.hightAttack();
            }

            if (mainchar.GetCurrentAnimatorStateInfo(0).IsName("mediumatackidle"))
            {
                sword.mediumAttack();
            }
            sword.swordCollider.enabled = true;
        }
        else
        {
            sword.swordCollider.enabled = false;
        }

    }

    public void attackBegin() => isAttack = true;

    public void attackEnd() => isAttack = false;

    public void hide()
    {
        weapon.SetActive(false);
    }
    public void onhide()
    {

        weapon.SetActive(true);
    }
    public void shoot()
    {
        FX.SetActive(true);
        mainchar.SetBool("switchpistolidle", true);
    }
    public void shootend()
    {
        FX.SetActive(false);
        mainchar.SetBool("switchpistolidle", false);
    }
}