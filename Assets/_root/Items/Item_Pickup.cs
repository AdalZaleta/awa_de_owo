using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pickup : MonoBehaviour {

	public GameObject model;
	private float rotSpeed = 500;

	void OnTriggerEnter (Collider _col)
	{
		if (_col.gameObject.CompareTag("Player"))
		{
			Debug.Log ("Can PickUp");
			_col.SendMessage ("canPickUp", true, SendMessageOptions.DontRequireReceiver);
			_col.SendMessage ("setItem", gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	void OnTriggerExit(Collider _col)
	{
		if (_col.gameObject.CompareTag("Player"))
		{
			Debug.Log ("Exit PickUp");
			_col.SendMessage ("canPickUp", false, SendMessageOptions.DontRequireReceiver);
		}
	}

	public void PickUp()
	{
		Debug.Log ("Picked Up " + gameObject.name);
		model.GetComponent<MeshRenderer> ().material.color = Color.red;
		Destroy (gameObject, 1.0f);
	}
}
