using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ShipHealthViewController : MonoBehaviour
{
    public Color [] states = new Color[3];

    public Dummy dummy;

    public int initialStateIndex = 0;

    private int currentStateIndex;

    private Image imageComponent;

    public bool uiIsActive = false;

    public void init()
    {
        currentStateIndex = initialStateIndex;
        imageComponent = GetComponent<Image>();
        imageComponent.color = states[currentStateIndex];
        dummy.onDamage += onDamage;
    }

    public void onDamage(int health)
    {        
        imageComponent.color = states[states.Length - health];
    }
}
