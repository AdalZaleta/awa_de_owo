using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (StartGame ());
	}

	IEnumerator StartGame()
	{
		yield return new WaitForSeconds (20.0f);
		SceneManager.LoadScene (1);
	}
}
