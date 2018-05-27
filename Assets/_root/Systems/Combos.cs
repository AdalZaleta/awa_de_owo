using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAAI
{
	public class Combos : MonoBehaviour {

		private KeyCombo falconPunch = new KeyCombo(new string[] {"down", "right","right"});
		private KeyCombo falconKick = new KeyCombo(new string[] {"down", "right","Fire1"});
		private KeyCombo easteregg = new KeyCombo(new string[] {"left", "right", "left", "right", "Right_Trigger", "Right_Trigger", "Control_Y"});
		private KeyCombo OGkonami = new KeyCombo(new string[] {"up", "up", "down", "down", "left", "right", "left", "right", "Fire2", "Jump", "Control_Start"});

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
				Manager_Static.scenManager.LoadSceneAdd (4);
				Debug.Log ("EASTER EGG BOI");
			}
			if (OGkonami.Check() && Manager_Static.scenManager.currentScene.name == "Prototype")
			{
				Manager_Static.soundManger.PlayMagic ();
				Manager_Static.scenManager.OpenEasterEgg ();
			}
		}
	}
}