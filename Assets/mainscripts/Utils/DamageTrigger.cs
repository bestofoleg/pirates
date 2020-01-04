using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public string damageForObjectWithTag = "Player";
    
    public int damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(damageForObjectWithTag))
        {
            Dummy dummy = other.gameObject.GetComponent<Dummy>();
            dummy.Damage(damage);
        }

    }
}
