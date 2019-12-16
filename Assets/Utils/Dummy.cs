using UnityEngine;
using UnityEngine.UI;

public class Dummy : MonoBehaviour
{
    private const string DummyIsDeathMessage = "Dummy is death!";
    
    private int health;

    public BulkMessageWordUI damageQuantityTextUI;
    
    public int maxHealth;

    private void Awake()
    {
        health = maxHealth;
    }

    public void Damage(int damage)
    {
        BulkMessageWordUI damageQuantity = Instantiate(damageQuantityTextUI);
        damageQuantity.StartBulk(this.transform);
        if (health > 0)
        {
            health -= damage;
            damageQuantity.text.text = damage.ToString();
        }
        else
        {
            damageQuantity.text.text = DummyIsDeathMessage;
        }
    }
}
