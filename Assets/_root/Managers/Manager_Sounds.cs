using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Manager_Sounds : MonoBehaviour {

		public AudioSource OST;
		public AudioSource SFX;

		void Awake()
		{
			Manager_Static.soundManger = this;
		}

		public void PlayMagic()
		{
			SFX.PlayOneShot (Resources.Load ("easteregg.mp3") as AudioClip);
		}
	}
}