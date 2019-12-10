using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldView : MonoBehaviour
{
    public Text goldQuantityText;
    
    private int quantity;

    private void Awake()
    {
        quantity = 0;
        goldQuantityText.text = quantity.ToString();
    }

    private void Update()
    {
        goldQuantityText.text = quantity.ToString();
    }

    public int getGlodQuantity()
    {
        return quantity;
    }

    public void setGoldQuantity(int quantity)
    {
        this.quantity = quantity;
    }
}
