using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGunShoot : MonoBehaviour
{
    public GameObject ballpref;
    public float power_shoot;
    public Transform muzzle_point;
    private GameObject ball;

    public void Shoot_l()
    {
        ball = Instantiate(ballpref, muzzle_point.position, muzzle_point.rotation);
        ball.GetComponent<Rigidbody>().AddForce((ball.transform.forward + (ball.transform.up / 2f)) * power_shoot, ForceMode.Impulse);

    }
    private void Update()
    {
        Destroy(ball, 3f);
    }
}
