﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Manager_UI : MonoBehaviour {

		public GameObject minimenu;
		public float TimeScale;

		void Awake()
		{
			Manager_Static.uiManager = this;
			TimeScale = Time.timeScale;
		}

		public void PauseTime()
		{
			Time.timeScale = 0.0f;
			if (minimenu)
				minimenu.SetActive (true);
		}

		public void ShowTime()
		{
			Time.timeScale = TimeScale;
			if (minimenu)
				minimenu.SetActive (false);
		}
	}
}