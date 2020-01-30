using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShootGunsControll : MonoBehaviour
{   
    public List<ShipGunShoot> Fire;
    public GameObject l_fire;
    public GameObject r_fire;
    public Colldownfire fire_l;
    public Colldownfire fire_r;


    public void Shots_l() {
        l_fire.SetActive(true);
        fire_l.colldowns.fillAmount = 1;
           
        
        for (int i = 0; i < Fire.Count; i++) {
            
            Fire[i].Shoot_l();

        
        
        }


    }
    public void Shoot_r() {
        r_fire.SetActive(true);
        fire_r.colldowns.fillAmount = 1;
        for (int i = 0; i < Fire.Count; i++)
        {

            Fire[i].Shoot_l();



        }
    }
    
}
