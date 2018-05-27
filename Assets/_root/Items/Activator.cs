using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

	public GameObject objectoToActive;
	public bool isActive = true;
	public GameObject key;

	public void HitByRay() {
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		objectoToActive.GetComponent<Light>().enabled = !isActive;
		isActive = !isActive;
		key.SendMessage ("unLock", gameObject, SendMessageOptions.DontRequireReceiver);
	}
}
