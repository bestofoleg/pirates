using UnityEngine;
using UnityEngine.EventSystems;

public class RudderController : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public ShipController shipController;

    public void OnBeginDrag(PointerEventData eventData) {
        shipController.setIsRotate(true);
    }

    public void OnEndDrag(PointerEventData eventData) {
        shipController.setIsRotate(false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (shipController.forwardspeedsail == 0)
        {
            shipController.enabled = false;
        }
        else
        {   
            shipController.enabled = true;
            transform.localRotation = Quaternion.Euler(

                    transform.localRotation.x,
                    transform.localRotation.y,
                    -(eventData.position.x / Screen.width) * 360
                );
            shipController.rotateShip(eventData.delta.x);
            

        }
    }
}
