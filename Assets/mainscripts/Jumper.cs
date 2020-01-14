using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Jumper : MonoBehaviour
{
    string PlayerTag;
    
   public Animator anim;
    GameObject Player;
   public NavMeshAgent mesh;
    public GameObject Enemy;
    public HpPlayer hpplayer;
    
    Rigidbody rig;
    CapsuleCollider caps;
    void Start()
    {  
        caps = GetComponent<CapsuleCollider>();
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false;
        caps.enabled = false;
        mesh = GetComponent<NavMeshAgent>();
        mesh.enabled = false;
        anim = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player");
        anim.SetBool("enemys", false);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            
            anim.SetBool("enemys", true);
         
            Debug.Log(Player.transform.position);
        }



    }
    public void DamageOnPlayer(Collider other)
    {
       
            hpplayer.hp -= 0.1f;
      

    }


    void Update()
    {
        
        mesh.SetDestination(Player.transform.position);
    }
    public void usegrav()
    { 
        mesh.enabled = true;
        caps.enabled = true;
        rig.useGravity = true;
    }
}
