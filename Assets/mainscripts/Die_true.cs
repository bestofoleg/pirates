using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die_true : MonoBehaviour
{
 
    public EnemyInfo info;
    void Start()
    {
        info = EnemyInfo.FindObjectOfType<EnemyInfo>();
        info.Info += 1;
       
    }

   
}
