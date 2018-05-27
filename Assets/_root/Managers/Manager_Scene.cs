using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TAAI
{
	public class Manager_Scene : MonoBehaviour {

		public GameObject options;
		public Scene currentScene;
		public int nextSceneId;

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

		public void OpenEasterEgg()
		{
			options.SetActive (false);
		}
		
		public void LoadNextLevel()
		{
			SceneManager.LoadScene (nextSceneId);
		}
=======
>>>>>>> parent of e030501... todos
=======
>>>>>>> parent of e030501... todos
	}
}
