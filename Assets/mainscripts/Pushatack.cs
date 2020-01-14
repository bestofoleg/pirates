using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Pushatack : MonoBehaviour
{
    
    public Rigidbody rh;
    
    void Start()
    {

       
    
    }

   
    void Pushbody()
    {
        rh.AddForce(Vector3.up * 10);
    }
}
