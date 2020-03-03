using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumperdie : MonoBehaviour
{
    public EnemyInfo status;
    float timedel = 20;
    GameObject capsule;
    public Die_true dd;
    public bool die;
    public Jumper enm;
    public GameObject l, l1;
    public Dummy HP;
    private int HPh;
    public List<CapsuleCollider> mainc;
    public List<Collider> ragdoll;
    public List<Rigidbody> rig;
    void Start()
    {
        capsule = GetComponent<GameObject>();
        die = false;
    }

  
    void Update()
    {
        if (die == true)
        {

            dd.enabled = true;

        }

        status = EnemyInfo.FindObjectOfType<EnemyInfo>();

        if (HPh > 0)
        {
            for (int i = 0; i < rig.Count; i++)
            {
                rig[i].useGravity = false;
                
            }
        }
        
        HPh = HP.health;
        if (HPh <= 0)
        {
            timedel -= Time.deltaTime;
            if (timedel <= 0)
            {

                Destroy(this.gameObject);

            }
            die = true;
            l.SetActive(false);
            l1.SetActive(false);
            enm.anim.enabled = false;
            enm.mesh.enabled = false;
            enm.enabled = false;
            for (int i = 0; i < mainc.Count; i++)
            {
                
                mainc[i].isTrigger = true;
            }
            for (int i = 0; i < ragdoll.Count; i++)
            {

                ragdoll[i].isTrigger = false;

            }
            for (int i = 0; i < rig.Count; i++)
            {
                rig[i].useGravity = true;
                rig[i].isKinematic = false;
            }
        }


    }
}
