using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper_gravityskl : MonoBehaviour
{
   public GameObject skl;
    
    void Start()
    {
        
        skl.SetActive(false);
    }

    // Update is called once per frame
  public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            skl.SetActive(true);
        }
           
    }
}
