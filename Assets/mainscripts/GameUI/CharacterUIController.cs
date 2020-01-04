using UnityEngine;

public class CharacterUIController : MonoBehaviour
{
    public GoldView goldView;

    private Inventory _inventory;

    public GameObject fishmanInteractionMenu;

    public GameObject gunmanInteractionMenu;
    

    private void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");
        _inventory = player.GetComponent<Inventory>();

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


}

