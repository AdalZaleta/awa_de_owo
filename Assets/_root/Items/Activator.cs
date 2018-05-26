using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

	public GameObject objectoToActive;
	public bool isActive = true;

	public void HitByRay() {
		objectoToActive.SetActive (!isActive);
		isActive = !isActive;
	}
}
