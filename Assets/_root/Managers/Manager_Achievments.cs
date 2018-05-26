using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Manager_Achievments : MonoBehaviour {



		void Awake()  
		{
			Manager_Static.achievmentsManager = this;
		}

		void UnlockAchive(int i)
		{
		}
	}
}