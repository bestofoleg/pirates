using UnityEngine;

public class ShipController : MonoBehaviour
{
    public ShipAnimationController shipAnimationController;
    public string playerTag = "Player";
    private ShipAnimationController.ShipAnimationState shipAnimationState;
    public int forwardspeedsail;
    public float moveSpeed;
    public Animator anim;
    public float rotateSpeed;

    public Rigidbody shipRigidbody;

    public Transform characterTransform;

    public Transform targetPoint;

    private bool isRotate;

    private float currentYAngle;

    private void Awake() 
    {
        currentYAngle = transform.rotation.eulerAngles.y;
        isRotate = false;
        shipAnimationState = new ShipAnimationController.ShipAnimationState();    
    }
   
    public void rotateShip(float scale)
    {
        currentYAngle += scale * rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.AngleAxis(
            currentYAngle,
            Vector3.up
        );
        if (scale > 0) 
            shipAnimationState.setToRigthState();
        if(scale < 0)
            shipAnimationState.setToLeftState();
    }

    public void setIsRotate(bool isRotate) {
        this.isRotate = isRotate;
    }

    private void Update()
    {        
        shipAnimationController.translateToAnimationState(ref shipAnimationState);

        if(!isRotate) {
            shipAnimationState.toFloatingState();
        }

        if (forwardspeedsail == 1)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            //shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
        }
        if (forwardspeedsail >= 2)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            //shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime * 2);
        }
        if (forwardspeedsail == 0)
        {
            transform.position += transform.forward * 0 * Time.deltaTime;
            //shipRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * 0 * Time.deltaTime);
        }

        if (forwardspeedsail < 0)
        {
            forwardspeedsail = 0;
        }
        if (forwardspeedsail > 2)
        {
            forwardspeedsail = 2;
        }
        characterTransform.position = targetPoint.position;
        characterTransform.rotation = transform.rotation;
    }
}
