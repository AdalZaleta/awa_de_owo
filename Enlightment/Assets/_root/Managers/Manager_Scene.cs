using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FPSBoys
{
	public class Manager_Scene : MonoBehaviour {

		public GameObject options;

		void Awake()
		{
			Manager_Static.scenManager = this;
		}

		public void LoadScene(int _scene)
		{
			SceneManager.LoadScene (_scene, LoadSceneMode.Single);
		}

		public void QuitGame()
		{
			Application.Quit ();
		}
	}
}
