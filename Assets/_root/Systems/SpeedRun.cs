using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRun : MonoBehaviour {

	public static float timer;
	public static bool timeStarted = false;
	
	void OnGUI() {
		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

		GUI.Label(new Rect(10,10,250,100), niceTime);
	}
}
