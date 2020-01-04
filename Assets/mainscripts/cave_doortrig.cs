using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cave_doortrig : MonoBehaviour
{
    public Cave_door open;
    public float timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            open.cdoor.SetBool("open", true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && timer <= 0)
        {
            open.cdoor.SetBool("open", false);
        }

    }


    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

    }
}
