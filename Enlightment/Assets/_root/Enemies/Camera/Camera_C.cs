using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Camera_C : MonoBehaviour {

		RaycastHit hit;
		
		// Update is called once per frame
		void Update () {
			if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity) && hit.transform.CompareTag("Player")) {
				Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.yellow);
				Debug.Log ("Estoy tocando : " + hit.transform.name);
				Manager_Static.scenManager.LoadScene (3);
			}
		}
	}
}
