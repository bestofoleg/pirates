using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootpistol : MonoBehaviour
{
    public Dummy dum;
    public float hitpower;
    public float distance;
    private RaycastHit hits;
   
    public void Shot()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hits, distance))
        {    if(hits.transform.tag == "Enemy")
            {
                dum.GetComponent<Dummy>();
                dum.health -= 80;
            
            }
            Debug.Log("cross object" + hits.transform.tag);
        }
        else
        {
            Debug.Log("notcross object" );
        }
    }
}
