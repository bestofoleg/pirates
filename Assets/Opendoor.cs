using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    
    public EnemyInfo inf;
    public int normal;
   private int cl;
    // Start is called before the first frame update
    void Start()
    {
        inf = EnemyInfo.FindObjectOfType<EnemyInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        cl = inf.Info;
        
        if (normal <= cl) {

         Destroy(this.gameObject);

        }

    }
}
