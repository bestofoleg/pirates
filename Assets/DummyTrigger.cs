using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTrigger : Dummy {
    public string damageObjectsTag = "Bullet";    

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.Equals(damageObjectsTag)) {
            Bullet bullet = other.gameObject.GetComponent<Bullet> ();
            Damage(bullet.damage);
        }
    }
}
