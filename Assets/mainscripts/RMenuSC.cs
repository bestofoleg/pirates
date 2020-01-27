using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMenuSC : MonoBehaviour
{
    public GameObject Button;
    public GameObject Radial;
    public GameObject Close;
    public Animator Open;

    void Start()
    {
        Radial.SetActive(false);
        
    }

    public void On()
    {
        Close.SetActive(false);
        Button.SetActive(false);
        Radial.SetActive(true);
        Open.SetBool("null", false);
        Open.SetBool("isClose", false);
    }
}
