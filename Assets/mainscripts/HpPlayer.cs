using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpPlayer : MonoBehaviour
{
    public Image hpp;
    public float hp;
    void Start()
    {
        
    }

   
    void Update()
    {
        hpp.fillAmount = hp;
    }
}
