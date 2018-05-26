using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TAAI
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

		public void LoadSceneAdd(int _scene)
		{
			SceneManager.LoadSceneAsync (_scene, LoadSceneMode.Additive);
		}

		public void UnLoadScene(int _scene)
		{
			SceneManager.UnloadSceneAsync (_scene);
		}

		public void QuitGame()
		{
			Application.Quit ();
		}
	}
}
