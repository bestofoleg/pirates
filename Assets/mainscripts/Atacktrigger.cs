using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacktrigger : MonoBehaviour
{
 public Enemysc enem;
        
    void Start()
    {
        
    }


  public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy") {
            enem.anim.SetBool("enemys", false);
            enem.anim.SetBool("enemesidle", true);
            Debug.Log("he enter");
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            enem.anim.SetBool("enemys", true);

            enem.anim.SetBool("enemesidle", false);
            Debug.Log("he exit");
        }
    }
   
    }

