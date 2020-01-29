using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string dummyTag = "Dummy";

    public int damage;

    private void OnTriggerEnter(Collider other) {
            if (dummyTag.Equals(other.gameObject.tag)) {
                other.gameObject.GetComponent<Dummy>().Damage(damage);
                Destroy(this.gameObject);
            }
    }
}
