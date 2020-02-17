using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGun : MonoBehaviour {
    public Rigidbody bulletPrefab;

    public Transform bulletSpawnPoint;

    public float gunForce;

    public void shoot() {
        Rigidbody currentBullet = GameObject.Instantiate(
            bulletPrefab,
            bulletSpawnPoint.transform.position,
            bulletSpawnPoint.transform.rotation
        );
        currentBullet.AddForce(bulletSpawnPoint.transform.forward * gunForce);
    }
}
