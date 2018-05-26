using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret_C : MonoBehaviour {

	RaycastHit hit;
	public Animator anim;

	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.right), out hit, Mathf.Infinity) && hit.transform.CompareTag ("Player")) {
			Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.right) * hit.distance, Color.yellow);
			Debug.Log ("Estoy tocando : " + hit.transform.name);
			anim.SetTrigger ("Detec");
		} else {
			anim.SetTrigger ("Desactive");
		}
	}
}
