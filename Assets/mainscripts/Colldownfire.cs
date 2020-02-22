using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Colldownfire : MonoBehaviour
{   
    public GameObject fill;
    public Image colldowns;
    
    void Start()
    {
        fill.SetActive(false);
    }

    
    void Update()
    {   
        if (colldowns.fillAmount == 0) 
        {
            fill.SetActive(false);       
        }
    }
}
