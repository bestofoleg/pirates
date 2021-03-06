﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyInteraction : MonoBehaviour
{
   private GameObject gunmannomoney;
    private Inventory money;
    public string playerTag;
    public string nomtag;
    public string characterUITag;
    
    public InteractionType interactionType;

    private GameObject playerGameObject;

    private GoldView _goldView;

    private CharacterUIController _controller;

    private void Start()
    {

        GameObject lol = GameObject.FindGameObjectWithTag("NoNo");
        GameObject player = GameObject.FindWithTag("Player");
        money = player.GetComponent<Inventory>();
        playerGameObject = GameObject.FindWithTag(playerTag);
        GameObject characterUI = GameObject.FindWithTag(characterUITag);
        gunmannomoney = lol;
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
            _controller.activeCaveGirlMenu(InteractionType.CAVEGIRL.Equals(interactionType));

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
                gunmannomoney.SetActive (false);
                _controller.activateGunmanMenu(false);
            }
            if (InteractionType.CAVEGIRL.Equals(interactionType))
            {
                _controller.activeCaveGirlMenu(false);
            }
        }
    }
    public void OnTriggerStay (Collider other)
    {
        

        if (other.tag.Equals(playerTag))
        {
            _controller.activeCaveGirlMenu(InteractionType.CAVEGIRL.Equals(interactionType));
           
            
            if (InteractionType.GUNMAN.Equals(interactionType)) { 

            
            if (money.goldQuantity < 500)
                {
                    
                    _controller.activateGunmanMenu(false);
                    gunmannomoney.SetActive(true);
                
                }
            
            }
            
        }
    }
}
