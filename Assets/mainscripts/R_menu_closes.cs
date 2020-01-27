using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_menu_closes : MonoBehaviour
{
    public GameObject Button;
    public GameObject Radial;
    public GameObject Close;
    public Animator Open;
   
    

    public void off()
    {
        
        Close.SetActive(true);
        Button.SetActive(true);
        Open.SetBool("null", true);
        Open.SetBool("isClose", true);


    }
}