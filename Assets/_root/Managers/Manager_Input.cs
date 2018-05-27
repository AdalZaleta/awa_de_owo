using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

namespace TAAI
{	
	public class Manager_Input : MonoBehaviour {

		private string[] Commands;

		void Awake()
		{
			//ASIGNO AL MANAGER STATIC CUAL VA A SER EL INPUT MANGER
			Manager_Static.inputManager = this;
		}

		void Update()
		{
			//CODIGO DE LOS INPUTS DEPENDIEDO DEL ESTADO DEL JUEGO

			//LOS INPUTS DE CUANDO ESTES EN EL MENU PRINCIPAL
			if (Manager_Static.appManager.currentState == AppState.main_menu) {
			}

			//LOS INPUTS DE CUANDO ESTES EN GAMEPLAY
			if (Manager_Static.appManager.currentState == AppState.gameplay) {
				Manager_Static.uiManager.ShowTime ();
				if (Input.GetAxisRaw ("Left_Trigger") <= -0.5f) {
					SendMessage ("aim", true, SendMessageOptions.DontRequireReceiver);
				}
				if (Input.GetAxisRaw ("Right_Trigger") <= -0.7f || Input.GetKeyDown (KeyCode.Mouse0)) {
					GamePad.SetVibration (PlayerIndex.One, 0.25f, 0.25f);
					ShootHandler (1);
				}
				if (Input.GetAxisRaw ("Right_Trigger") > -0.5f) {
					GamePad.SetVibration (PlayerIndex.One, 0f, 0f);
				}
				if (Input.GetButtonDown("Control_Y"))
				{
					DecalHandler (1);
					Debug.Log ("Pressed Y Button");
				}
				if (Input.GetButtonDown("R_Bumper"))
				{
					DecalChangeHandler (1);
					Debug.Log("Pressed Right Bumper");
				}
				if (Input.GetButtonDown("L_Bumper"))
				{
					DecalChangeHandler (-1);
					Debug.Log("Pressed Left Bumper");
				}
				if (Input.GetButtonDown("Control_Start"))
				{
					Manager_Static.scenManager.LoadSceneAdd (2);
					Manager_Static.appManager.currentState = AppState.pause_menu;
					Debug.Log ("Paused");
				}
			}

			//LOS INPUTS DE CUANDO ESTES EN GAME_MENU
			else if (Manager_Static.appManager.currentState == AppState.pause_menu) {
				Manager_Static.uiManager.PauseTime ();
				if (Input.GetKeyDown (KeyCode.JoystickButton6)) 
				{
					Manager_Static.scenManager.UnLoadScene (2);
					Manager_Static.appManager.currentState = AppState.gameplay;
					Debug.Log ("UnPaused");
				}
				if (Input.GetButtonDown("Control_Start"))
				{
					Manager_Static.scenManager.UnLoadScene (2);
					Manager_Static.appManager.currentState = AppState.gameplay;
					Debug.Log ("UnPaused");
				}
			}

			//LOS INPUTS DE CUANDO ESTES EN END_GAME
			else if (Manager_Static.appManager.currentState == AppState.end_game) {
				if (Input.GetButtonDown("Control_Start"))
				{
					Manager_Static.scenManager.LoadScene (1);
				}
			}
		}

		void AddCommand(string commName)
		{
			Commands.SetValue (commName, Commands.Length);
		}

		void CommandsList()
		{
			
		}

		public delegate void InputTemplate (int _id);

		public InputTemplate AchievementHandler;
		public InputTemplate DecalChangeHandler;
		public InputTemplate DecalHandler;
		public InputTemplate ShootHandler;
		public InputTemplate ShootDownHandler;
		public InputTemplate ShootUpHandler;
		public InputTemplate ThrowHandler;
		public InputTemplate SwitchWeaponHandler;
	}
}
