using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterParametersView : MonoBehaviour
{
    private Image healthImage;

    public Dummy characterDummy;

    private void Awake()
    {
        healthImage = GetComponent<Image>();
    }

    private void Update()
    {
        healthImage.fillAmount = (float) characterDummy.Health / characterDummy.maxHealth;
    }
}
