﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyInteraction : MonoBehaviour
{
    public string playerTag;

    public string characterUITag;
    
    public InteractionType interactionType;

    private GameObject playerGameObject;

    private GoldView _goldView;

    private CharacterUIController _controller;

    private void Awake()
    {
        playerGameObject = GameObject.FindWithTag(playerTag);
        GameObject characterUI = GameObject.FindWithTag(characterUITag);
        if (characterUI != null)
        {
            _controller = characterUI.GetComponent<CharacterUIController>();
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
            _controller.activateFishmanMenu(InteractionType.FISHMAN.Equals(interactionType));
            _controller.activateGunmanMenu(InteractionType.GUNMAN.Equals(interactionType));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals(playerTag))
        {
            if (InteractionType.FISHMAN.Equals(interactionType))
            {
                _controller.activateFishmanMenu(false);
            }

            if (InteractionType.GUNMAN.Equals(interactionType))
            {
                _controller.activateGunmanMenu(false);
            }
        }
    }
}
