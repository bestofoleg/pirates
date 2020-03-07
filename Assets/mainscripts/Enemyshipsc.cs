using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemyshipsc : MonoBehaviour
{
    
   public GameObject Ship;
   public NavMeshAgent mesh;
    public GameObject Enemy;
    
    void Start()
    {
       
        mesh = GetComponent<NavMeshAgent>();
        mesh.enabled = true;
        mesh.SetDestination(Ship.transform.position);
        Ship = GameObject.FindWithTag("Ship");



    }
    private void Update()
    {
       
        Ship = GameObject.FindWithTag("Ship");
        mesh.SetDestination(Ship.transform.position);
    }



}


   
    

