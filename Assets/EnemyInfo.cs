using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    public List<GameObject> enemy;
    public int enemy_info;
    void Start()
    {
        
    }

   
    void Update()
    {
        enemy_info = enemy.Count;

    }
}
