﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumperdie : MonoBehaviour
{
    public Jumper enm;
    public GameObject l, l1;
    public Dummy HP;
    private int HPh;
    public List<CapsuleCollider> mainc;
    public List<Collider> ragdoll;
    public List<Rigidbody> rig;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (HPh > 0)
        {
            for (int i = 0; i < rig.Count; i++)
            {
                rig[i].useGravity = false;
                
            }
        }
        
        HPh = HP.health;
        if (HPh <= 0)
        {
            l.SetActive(false);
            l1.SetActive(false);
            enm.anim.enabled = false;
            enm.mesh.enabled = false;
            enm.enabled = false;
            for (int i = 0; i < mainc.Count; i++)
            {
                
                mainc[i].isTrigger = true;
            }
            for (int i = 0; i < ragdoll.Count; i++)
            {

                ragdoll[i].isTrigger = false;

            }
            for (int i = 0; i < rig.Count; i++)
            {
                rig[i].useGravity = true;
                rig[i].isKinematic = false;
            }
        }


    }
}
