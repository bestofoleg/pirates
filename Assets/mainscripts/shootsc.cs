using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootsc : MonoBehaviour
{   public HpPlayer hp;
    public bool bl;
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

    public void blStart()
    {
        
        bl = true;

    }
    public void blend()
    {
        
        anim.SetBool("Block", false);
        bl = false;

    }

    public void blactive() {

        anim.SetBool("Block",true);
    }
}
