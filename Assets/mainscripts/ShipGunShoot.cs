using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipGunShoot : MonoBehaviour
{
    public float timer;
    public GameObject ballpref;
    public float power_shoot;
    public Transform muzzle_point;
    private GameObject ball;
    public GameObject smoke;
    private GameObject smokespawn;
    public void Shoot_l()
    {
        timer = 1000;
        ball = Instantiate(ballpref, muzzle_point.position, muzzle_point.rotation);
        ball.GetComponent<Rigidbody>().AddForce((ball.transform.forward + (ball.transform.up / 2f)) * power_shoot, ForceMode.Impulse);
        smokespawn = Instantiate(smoke, muzzle_point.position,muzzle_point.rotation);
    }

    public void Shoot_r()
    {
        timer = 1000;
        ball = Instantiate(ballpref, muzzle_point.position, muzzle_point.rotation);
        ball.GetComponent<Rigidbody>().AddForce((ball.transform.forward + (ball.transform.up / 2f)) * - power_shoot, ForceMode.Impulse);
        smokespawn = Instantiate(smoke, muzzle_point.position,muzzle_point.rotation);
    }
    private void Update()    
    {
        timer -= 1f;
        if (timer < 0) { 
            timer = 0;}
        if (timer ==0) {
            DestroyImmediate(smokespawn, true); }
        Destroy(smokespawn, 1f);
        Destroy(ball, 3f);
    }
}
