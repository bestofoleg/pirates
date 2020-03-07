using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemysc : MonoBehaviour
{
    string PlayerTag;
  public  shootsc scs;
   public Animator anim;
    GameObject Player;
   public NavMeshAgent mesh;
    public GameObject Enemy;
    public HpPlayer hpplayer;
    void Start()
    {
        scs = shootsc.FindObjectOfType<shootsc>();
        mesh = GetComponent<NavMeshAgent>();
        mesh.enabled = false;
        anim = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player");
        anim.SetBool("enemys", false);
        hpplayer = GetComponent<HpPlayer>();
        hpplayer = HpPlayer.FindObjectOfType<HpPlayer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            mesh.enabled = true;
            anim.SetBool("enemys", true);
         
            Debug.Log(Player.transform.position);
        }



    }
    public void DamageOnPlayer(Collider other)
    {
        if (scs.bl == true) {
            hpplayer.hp -= 0.1f;
        }
        if (scs.bl == false)
        {
            hpplayer.hp -= 0f;
        }
    }


    void Update()

    { if(!Player) {
            hpplayer = HpPlayer.FindObjectOfType<HpPlayer>();
            Player = GameObject.FindWithTag("Player"); }
       
     
        mesh.SetDestination(Player.transform.position);
    }
    
}
