using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnplayer;
    

    public void CreatePlayer ()
    {
        GameObject temp = GameObject.Instantiate(spawnplayer);
        temp.transform.parent = transform;
        temp.transform.localPosition = Vector3.zero;
        temp.transform.localRotation = Quaternion.Euler(Vector3.zero);
        temp.transform.parent = null;
        this.GetComponent<spawn>().enabled = false;
    }
    private void Update()
    {
        if (!FindObjectOfType<Camera>()) {

            CreatePlayer();
        }
    }
}
