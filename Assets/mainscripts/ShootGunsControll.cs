using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShootGunsControll : MonoBehaviour
{   
    public ShipGunShoot [] leftGuns;
    public ShipGunShoot [] rightGuns;
    public GameObject l_fire;
    public GameObject r_fire;
    public Colldownfire fire_l;
    public Colldownfire fire_r;

    public void Shots_l() {
        l_fire.SetActive(true);
        fire_l.colldowns.fillAmount = 1;
           
        for (int i = 0; i < leftGuns.Length; i++) {
            leftGuns[i].Shoot_l();
        }
    }
    public void Shoot_r() {
        r_fire.SetActive(true);
        fire_r.colldowns.fillAmount = 1;
        for (int i = 0; i < rightGuns.Length; i++)
        {
            Debug.Log(rightGuns);
            Debug.Log(rightGuns[i]);
            rightGuns[i].Shoot_r();
        }
    }
    
}
