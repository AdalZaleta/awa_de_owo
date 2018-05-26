using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Test : MonoBehaviour {

	private KeyCombo falconPunch= new KeyCombo(new string[] {"down", "right","right"});
	private KeyCombo falconKick= new KeyCombo(new string[] {"down", "right","Fire1"});

	void Update () {
		if (falconPunch.Check())
		{
			// do the falcon punch
			Debug.Log("PUNCH"); 
		}		
		if (falconKick.Check())
		{
			// do the falcon punch
			Debug.Log("KICK"); 
		}
	}
}
