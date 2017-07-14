using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cardsmove : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {


	public void OnBeginDrag(PointerEventData eventDate)
	{
		Debug.Log ("OnBeginDrag");
	}

	public void OnDrag(PointerEventData eventData)
	{
		Debug.Log ("OnDrag");

		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log ("OnEndDrag");
	}
}
