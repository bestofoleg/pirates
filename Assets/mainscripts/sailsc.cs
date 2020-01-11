using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailsc : MonoBehaviour
{
    public ShipController speed;
    void Start()
    {
        
    }


  public  void SailUP()
    {
        speed.forwardspeedsail += 1;

    }
    public void SailDown()
    {
        speed.forwardspeedsail -= 1;

    }
}
