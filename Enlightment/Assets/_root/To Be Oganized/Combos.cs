using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combos : MonoBehaviour {

	private KeyCombo falconPunch = new KeyCombo(new string[] {"down", "right","right"});
	private KeyCombo falconKick = new KeyCombo(new string[] {"down", "right","Fire1"});
	private KeyCombo easteregg = new KeyCombo(new string[] {"left", "right", "left", "right", "Right_Trigger", "Right_Trigger", "Control_Y"});
	private KeyCombo test = new KeyCombo(new string[] {"left", "right", "left"});
	private KeyCombo testI = new KeyCombo(new string[] {"Right_Trigger", "Right_Trigger", "Right_Trigger"});

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
		if (easteregg.Check())
		{
			Debug.Log ("EASTER EGG BOI");
		}
		if (test.Check())
		{
			Debug.Log("Buttons work fine");
		}
		if (testI.Check())
		{
			Debug.Log ("Triggers are fine");
		}
	}
}
