using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TicTacToe : MonoBehaviour {

	public Button button;
	public Button botonr;
	public Text buttonText;
	public string playerSide;

	private Game_Controller gameController;

	public void SetSpace()
	{
		buttonText.text = gameController.GetPlayerSide ();
		button.interactable = false;
		botonr.Select ();
		gameController.EndTurn ();
	}

	public void SetGameControllerReference(Game_Controller controller)
	{
		gameController = controller;
	}
}
