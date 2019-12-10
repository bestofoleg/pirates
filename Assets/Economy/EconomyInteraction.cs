using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyInteraction : MonoBehaviour
{
    public string playerTag;

    public string characterUITag;
    
    public string interactionType;

    private GameObject playerGameObject;

    private GoldView _goldView;

    private CharacterUIController controller;
    
    private void Awake()
    {
        playerGameObject = GameObject.FindWithTag(playerTag);
        GameObject characterUI = GameObject.FindWithTag(characterUITag);
        if (characterUI != null)
        {
            controller = characterUI.GetComponent<CharacterUIController>();
        }
        else
        {
            Debug.LogError("Error! Game Object with character UI tag " + characterUITag + " cannot found!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(playerTag))
        {
            if (interactionType.Equals("Fishman"))
            {
                controller.fishmanInteraction.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        controller.fishmanInteraction.SetActive(false);
    }
}
