using UnityEngine;
using UnityEngine.UI;

public class Dummy : MonoBehaviour
{
    public delegate void DamageHandler(int health);

    public event DamageHandler onDamage;

    public string dummyIsDeathMessage = "Dummy is death!";

    public bool isBulkDamage;
    
    public int health;

    public BulkMessageWordUI damageQuantityTextUI;

    public bool isTriggeredDummy = false;

    public int maxHealth;

    private void Awake()
    {
        health = maxHealth;
    }

    public void Damage(int damage)
    {
        if (isBulkDamage)
        {
            bulkDamage(damage);
        }
        
        spendHealth(damage);
        onDamage?.Invoke(health);
    }

    private void bulkDamage(int damage)
    {
        BulkMessageWordUI damageQuantity = Instantiate(damageQuantityTextUI);
        damageQuantity.StartBulk(this.transform);
        if (health > 0)
        {
            damageQuantity.text.text = damage.ToString();
        }
        else
        {
            damageQuantity.text.text = dummyIsDeathMessage;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (isTriggeredDummy && other.tag.Equals("Bullet")) {
            Bullet bullet = other.gameObject.GetComponent<Bullet> ();
            Damage(bullet.damage);
            Destroy(other.gameObject);
        }
    }

    private void spendHealth(int damage)
    {
        if (health > 0)
        {  
            health -= damage;
        }
    }

    public int Health => health;
}
