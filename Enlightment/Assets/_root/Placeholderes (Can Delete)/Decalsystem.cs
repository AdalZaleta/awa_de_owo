using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSBoys
{
	public class Decalsystem : MonoBehaviour {

		public GameObject[] sprites;
		public Camera cam;
		public LayerMask layerMask;
		private int selected_spr;

		void OnEnable()
		{
			Manager_Static.inputManager.DecalChangeHandler += SetSprite;
			Manager_Static.inputManager.DecalHandler += PlaceDecal;
		}

		void OnDisable()
		{
			Manager_Static.inputManager.DecalChangeHandler -= SetSprite;
			Manager_Static.inputManager.DecalHandler -= PlaceDecal;
		}

		void OnDestroy()
		{
			Manager_Static.inputManager.DecalChangeHandler -= SetSprite;
			Manager_Static.inputManager.DecalHandler -= PlaceDecal;
		}

		public void SetSprite(int spr_index)
		{
			selected_spr = spr_index;
		}

		public void PlaceDecal(int _i)
		{
			RaycastHit hit;
			if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
			{
				GameObject Graffitti = Instantiate (sprites [selected_spr], (hit.point) + (hit.normal * 0.01f), Quaternion.LookRotation(hit.normal));
				Destroy (Graffitti, 5.0f);
				Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * hit.distance, Color.red);
				Debug.Log ("Hit " + hit.collider.gameObject.name);
			}
			else
			{
				Debug.Log ("Didn't Hit Shit Boi");
			}
		}
	}
}
