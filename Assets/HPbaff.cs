using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPbaff : MonoBehaviour
{
    public  HpPlayer hp;
    void Start()
    {  
        hp = HpPlayer.FindObjectOfType<HpPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player") {
            hp.timer = 2f;
            hp.healS = true;
            
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            hp.healS = false;

        }
    }
}
