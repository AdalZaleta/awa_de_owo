using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour {

	public Button button;
	public Text buttonText;
	public string playerSide;

	private Game_Controller gameController;

	public void SetSpace()
	{
		buttonText.text = gameController.GetPlayerSide ();
		button.interactable = false;
		gameController.EndTurn ();
	}

	public void SetGameControllerReference(Game_Controller controller)
	{
		gameController = controller;
	}
}
