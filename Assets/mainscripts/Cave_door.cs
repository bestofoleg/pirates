﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave_door : MonoBehaviour
{
  
    public Animator cdoor;
   
    void Start()
    {

        cdoor = GetComponent<Animator>();
        cdoor.SetBool("open", false);

        
    }

   
}