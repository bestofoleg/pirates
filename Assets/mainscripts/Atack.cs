using UnityEngine;
using UnityEngine.EventSystems;

public class Atack : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
	
	
	public string animaName;
	
	public Animator atack;
	
	public virtual void OnPointerDown(PointerEventData pon)
	{
		atack.SetBool(animaName, true);
	}
	
	public virtual void OnPointerUp(PointerEventData pon)
	{
		atack.SetBool(animaName, false);
	}
}
