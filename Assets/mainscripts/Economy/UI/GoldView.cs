using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldView : MonoBehaviour
{
    public Text goldQuantityText;

    private CharacterUIController _characterUiController;

    private void Awake()
    {
        _characterUiController = GameObject.FindWithTag("character_ui").GetComponent<CharacterUIController>();
    }

    private void Update()
    {
        goldQuantityText.text = _characterUiController.getMoneyValue().ToString();
    }
}
