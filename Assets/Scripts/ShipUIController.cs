using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipUIController : MonoBehaviour
{
    public string playerTag = "Player";

    public string characterUITag = "character_ui";

    public string animationName = "Stayroot";

    public Transform targetPoint;

    private CharacterUIController characterUiController;

    private PlayerMoveController playerMoveController;

    private GameObject character;

    private GameObject shipUIView;

    private Animator characterAnimator;

    public ShipController shipController;

    private GameObject shipControlApproveMenu;

    private sailsc speedControllerUI;
  
    
    private void Awake()
    {
        GameObject ui = GameObject.FindWithTag(characterUITag);
        character = GameObject.FindWithTag(playerTag);
        characterUiController = ui.GetComponent<CharacterUIController>();
        playerMoveController = character.GetComponent<PlayerMoveController>();
        characterAnimator = character.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (playerTag.Equals(collider.gameObject.tag))
        {   
            characterUiController.setShipUIController(this);
            characterUiController.shipApproveMenuControl.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (playerTag.Equals(collider.gameObject.tag))
        {
            characterUiController.setShipUIController(this);
            characterUiController.shipApproveMenuControl.SetActive(false);
        }
    }

    public void setShipControlMode(bool mode)
    {
        characterUiController.moveView.SetActive(!mode);
        characterUiController.attackMedView.SetActive(!mode);
        characterUiController.attackView.SetActive(!mode);
        characterUiController.rotateJoystick.SetActive(!mode);
        playerMoveController.cameraTransform.rotation = targetPoint.rotation;
        playerMoveController.enabled = !mode;
        character.transform.position = targetPoint.position;
        characterAnimator.enabled = !mode;
        shipController.targetPoint = targetPoint;
        shipController.enabled = mode;
        speedControllerUI = mode ? characterUiController.sail : null;
        if (mode) {characterUiController.sail.speed = shipController;}
    }
}
