using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Camera_C : MonoBehaviour {

		public LayerMask layerMask;
		public GameObject camSpawn;

		void OnTriggerEnter(Collider _col)
		{
			if (_col.gameObject.CompareTag("Player"))
			{
				if (_col.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().lit)
				{
					Debug.Log ("noticed");
					Noticed (_col.gameObject);
				}
			}
		}

		void Noticed(GameObject _col)
		{
			RaycastHit hit;
			if (Physics.Raycast (camSpawn.transform.position, _col.transform.position - camSpawn.transform.position, out hit, Mathf.Infinity, layerMask))
			{
				Debug.DrawRay (camSpawn.transform.position, (_col.transform.position - camSpawn.transform.position) * hit.distance, Color.blue);
				Debug.Log ("Hit " + hit.collider.gameObject.name);
				if (hit.collider.gameObject.CompareTag("Player"))
				{
					Caught ();
				}
			}
		}

		void Caught()
		{
			Manager_Static.scenManager.LoadScene (6);
		}
	}
}
