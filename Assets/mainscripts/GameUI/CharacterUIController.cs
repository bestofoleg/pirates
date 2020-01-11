using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class CharacterUIController : MonoBehaviour
{
    public GoldView goldView;

    private Inventory _inventory;

    public GameObject fishmanInteractionMenu;

    public GameObject gunmanInteractionMenu;

    public GameObject cavegirlmenuact;

    public GameObject Mission;

    public GameObject attackView;

    public GameObject attackMedView;

    public GameObject moveView;

    public GameObject rotateJoystick;

    public GameObject shipApproveMenuControl;

    private ShipUIController _shipUIController;
    public GameObject sail;
    private void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");
        _inventory = player.GetComponent<Inventory>();
    }

    public void setShipUIController(ShipUIController shipUIController)
    {
        _shipUIController = shipUIController;
    }

    public void approveShipControl(bool mode)
    {
        sail.SetActive(true);
        _shipUIController.setShipControlMode(mode);
        shipApproveMenuControl.SetActive(false);
    }

    public void spendMoney(int quantity)
    {
        _inventory.goldQuantity -= quantity;
    }

    public void addMoney(int quantity)
    {
        _inventory.goldQuantity += quantity;

    }

    public int getMoneyValue()
    {
        return _inventory.goldQuantity;
    }

    public void activateFishmanMenu(bool isActive)
    {
        fishmanInteractionMenu.SetActive(isActive);
    }

    public void activateGunmanMenu(bool isActive)
    {
        gunmanInteractionMenu.SetActive(isActive);


    }
    public void activeCaveGirlMenu(bool isActive)
    {

        cavegirlmenuact.SetActive(isActive);


    }
    public void activeMissionMenu(bool isActive)
    {

        cavegirlmenuact.SetActive(false);
        Mission.SetActive(isActive);


    }







}

