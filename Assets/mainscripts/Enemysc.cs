using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemysc : MonoBehaviour
{ string PlayerTag;
   public Animator anim;
    GameObject Player;
   public NavMeshAgent mesh;
    public GameObject Enemy;
    void Start()
    {
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
            
            mesh.enabled = true;
            anim.SetBool("enemys", true);
         
            Debug.Log(Player.transform.position);
        }



    }
    
    void Update()
    {
        mesh.SetDestination(Player.transform.position);
    }
    
}
