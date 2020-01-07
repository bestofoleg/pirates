using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offallscrean : MonoBehaviour
{
    public GameObject mm;
    public List<GameObject> off;
    public List<GameObject> on;
    void Update()
    {
        {
            for (int i = 0; i < off.Count; i++)
            {

                off[i].SetActive(false);

            }
        }
    }


   public void Activeall(bool isActive)
    {    mm.SetActive(false);
        for (int i = 0; i < on.Count; i++)
        {

            on[i].SetActive(true);

        }

    }
}
