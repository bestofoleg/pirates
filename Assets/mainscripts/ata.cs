using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ata : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
	public Animator atack;
	void Start ()
	{
		
		atack.SetBool("Atack", false);

	}
	public virtual void OnPointerDown(PointerEventData pon)
	{
		
		atack.SetBool("Atack",true);
		Debug.Log("down");

	}
	public virtual void OnPointerUp(PointerEventData pon)
	{
		
		atack.SetBool("Atack", false);
		
	}

	
}
