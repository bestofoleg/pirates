﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffonBA : MonoBehaviour
{
    GameObject[] oncd;
    GameObject[] offmenu;
    GameObject[] onmenu;
    void Start()
    {
        oncd = GameObject.FindGameObjectsWithTag("Cdon");
        offmenu = GameObject.FindGameObjectsWithTag("offmenu");
        onmenu = GameObject.FindGameObjectsWithTag("onmenu");
    }


    void FixedUpdate()
    {
        for (int i = 0; i < oncd.Length; i++)
        {

            oncd[i].SetActive(false);
        }
        for (int i = 0; i < onmenu.Length; i++)
        {

            onmenu[i].SetActive(false);
        }

        for (int i = 0; i < offmenu.Length; i++)
        {

            offmenu[i].SetActive(true);
        }

    }
}
