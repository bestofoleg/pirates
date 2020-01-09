using UnityEngine;
using UnityEngine.EventSystems;

public class RudderController : MonoBehaviour, IDragHandler
{
    public ShipController shipController;
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.localRotation = Quaternion.Euler(
                transform.localRotation.x, 
                transform.localRotation.y, 
                - (eventData.position.x / Screen.width) * 360 
            );
        shipController.rotateShip(eventData.delta.x);
    }
}
