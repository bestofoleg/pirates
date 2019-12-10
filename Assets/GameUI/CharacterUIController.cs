using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUIController : MonoBehaviour
{
    public GoldView goldView;

    public GameObject fishmanInteraction;

    public void addMoney(int quantity)
    {
        goldView.setGoldQuantity(goldView.getGlodQuantity() + quantity);
    }
}
