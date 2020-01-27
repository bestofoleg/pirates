using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGunsControll : MonoBehaviour
{
   public List <ShipGunShoot> Fire;



    
    public void Shots_l() {

        
        for (int i = 0; i < Fire.Count; i++) {

            Fire[i].Shoot_l();

        
        
        }


    }
    public void Shoot_r() {
        for (int i = 0; i < Fire.Count; i++)
        {

            Fire[i].Shoot_l();



        }
    }
    
}
