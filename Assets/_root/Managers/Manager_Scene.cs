using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TAAI
{
	public class Manager_Scene : MonoBehaviour {

		public GameObject options;
<<<<<<< HEAD

		public Scene currentScene;
		public int nextSceneId;
=======
>>>>>>> parent of e030501... todos

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
<<<<<<< HEAD

<<<<<<< HEAD
		public void OpenEasterEgg()
		{
			options.SetActive (false);
=======
		public void LoadNextLevel()
		{
			SceneManager.LoadScene (nextSceneId);
>>>>>>> 4bc3d2d60531b3af5fad32c25e05771d1ed5f4d9
		}
=======
>>>>>>> parent of e030501... todos
	}
}
