using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipUIController : MonoBehaviour
{
    public ShipHealthUI shipHealthUI;

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

    public ShipGunShoot [] leftGuns = new ShipGunShoot [3];

    public ShipGunShoot [] rightGuns = new ShipGunShoot [3];
  
    
    private void initAllComponents(Collider collider) {
        character = collider.gameObject;
        playerMoveController = character.GetComponent<PlayerMoveController>();
        characterUiController = playerMoveController.uIController;
        playerMoveController.shootGunsControll.leftGuns.AddRange(leftGuns);
        playerMoveController.shootGunsControll.rightGuns.AddRange(rightGuns);
        characterAnimator = character.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (playerTag.Equals(collider.gameObject.tag))
        {   
            initAllComponents(collider);
            characterUiController.setShipUIController(this);
            characterUiController.shipApproveMenuControl.SetActive(true);
            for(int i = 0; i < characterUiController.shipHealthViewControllers.Length; i ++)
            {
                characterUiController.shipHealthViewControllers[i].dummy = shipHealthUI.dummies[i];
                characterUiController.shipHealthViewControllers[i].init();
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (playerTag.Equals(collider.gameObject.tag))
        {
            characterUiController.setShipUIController(this);
            characterUiController.shipApproveMenuControl.SetActive(false);
            for(int i = 0; i < characterUiController.shipHealthViewControllers.Length; i ++)
            {
                characterUiController.shipHealthViewControllers[i].dummy = null;
            }
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
        shipController.characterTransform = character.transform;
        characterAnimator.enabled = !mode;
        shipController.targetPoint = targetPoint;
        shipController.enabled = mode;
        speedControllerUI = mode ? characterUiController.sail : null;
        if (mode) {characterUiController.sail.speed = shipController;}
    }
}
