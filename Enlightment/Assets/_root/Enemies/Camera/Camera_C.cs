using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Camera_C : MonoBehaviour {

		void OnTriggerEnter(Collider _col)
		{
			if (_col.gameObject.CompareTag("Player"))
			{
				if (_col.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().lit)
				{
					Invoke ("Caught", 0.2f);
					//Manager_Static.scenManager.LoadScene (3);
				}
			}
		}

		void Caught()
		{
			Manager_Static.scenManager.LoadScene (3);
		}
	}
}
