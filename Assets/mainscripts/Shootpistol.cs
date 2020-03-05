using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootpistol : MonoBehaviour
{
    public Animator anim;
    public bool bl;
    public Dummy dum;
    public float hitpower;
    public float distance;
    private RaycastHit hits;
    public GameObject enemy;
    
    
    public void Shot()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hits, distance))
        {    if(hits.transform.tag == "Enemy")
            {
                enemy = hits.collider.gameObject.GetComponent<GameObject>();
                dum = hits.collider.gameObject.GetComponent<Dummy>();


                dum = enemy.GetComponent<Dummy>();
                if (!dum)
                {
                   
                    enemy = hits.collider.gameObject.GetComponent<GameObject>() ;
                    dum = hits.collider.gameObject.GetComponent<Dummy>();
                    if(enemy.name == "wakeup") {

                        Physics.Raycast(transform.position, transform.forward, out hits);
                        enemy = hits.collider.gameObject;

                        dum = hits.collider.gameObject.GetComponent<Dummy>();
                    }
                }
                
                dum.health -= 80;
            
            }
            Debug.Log("cross object" + hits.transform.tag);
        }
        else
        {
            Debug.Log("notcross object" );
        }
    }
    public void shootend()
    {
        anim.SetBool("switchpistolidle", false);
    }

    public void blStart()
    {
        bl = true;

    }
    public void blend()
    {
        anim.SetBool("Block", false);
        bl = false;

    }
}
