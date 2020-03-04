using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffandOnmenu : MonoBehaviour
{
    GameObject[] cds;
    GameObject[] offmenu;
    GameObject[] onmenu;
    void Start()
    {
        cds = GameObject.FindGameObjectsWithTag("Cdon");
        offmenu = GameObject.FindGameObjectsWithTag("offmenu");
        onmenu = GameObject.FindGameObjectsWithTag("onmenu");
    }

   
    void FixedUpdate ()
    {
        for (int i = 0; i < cds.Length; i++)
        {

            cds[i].SetActive(false);
        }
        for (int i = 0; i < onmenu.Length; i++)
        {

            onmenu[i].SetActive(true);
        }

        for (int i = 0; i < offmenu.Length; i++) {

            offmenu[i].SetActive(false);
        }
       
    }
}
