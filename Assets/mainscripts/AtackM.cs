using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AtackM : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
	
	public Animator atack;
	void Start()
	{

		atack.SetBool("MediumAtack", false);

	}
	public virtual void OnPointerDown(PointerEventData pon)
	{

		atack.SetBool("MediumAtack", true);
		Debug.Log("down");

	}
	public virtual void OnPointerUp(PointerEventData pon)
	{
		atack.SetBool("MediumAtack", false);

	}
}
