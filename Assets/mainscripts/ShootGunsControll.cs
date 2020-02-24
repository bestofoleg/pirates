using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootGunsControll : MonoBehaviour {   
    public List<ShipGunShoot> leftGuns = new List<ShipGunShoot>();

    public List<ShipGunShoot> rightGuns = new List<ShipGunShoot>();
    
    public GameObject l_fire;
    
    public GameObject r_fire;
    
    public Colldownfire fire_l;
    
    public Colldownfire fire_r;

    public void Shots_l() {
        l_fire.SetActive(true);
        fire_l.StartCountdownTimer();
        foreach (var leftGun in leftGuns) {
            leftGun.Shoot_l();
        }
    }

    public void Shoot_r() {
        r_fire.SetActive(true);
        fire_r.StartCountdownTimer();
        foreach (var rightGun in rightGuns) {
            rightGun.Shoot_r();
        }
    }
}
