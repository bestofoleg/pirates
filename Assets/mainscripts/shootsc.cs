using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootsc : MonoBehaviour
{

    public Animator anim;
    void Start()
    {
        
        
    }


  
    public void shoot()
    {
        anim.SetBool("switchpistolidle", true);
    }
    public void shootend ()
    {
        anim.SetBool("switchpistolidle", false);
    }
}
