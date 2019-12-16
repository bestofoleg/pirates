using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    private const string EnemyTeg = "Enemy";
    
    public int damage;

    [Range(0, 1)]
    private float scale;

    public int RealDamage
    {
        get => realDamage;
    }

    public Collider swordCollider;

    private int realDamage;

    private void Awake()
    {
        swordCollider = GetComponent<Collider>();
        scale = 1;
        RecalculateRealDamage();
    }

    private void RecalculateRealDamage() => realDamage = (int) (damage * scale);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(EnemyTeg))
        {
            Dummy dummy = other.GetComponent<Dummy>();
            RecalculateRealDamage();
            dummy.Damage(realDamage);
        }
    }

    public void hightAttack()
    {
        scale = 1.5f;
        RecalculateRealDamage();
    }

    public void mediumAttack()
    {
        scale = 1f;
        RecalculateRealDamage();
    }
}
