using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XInputDotNetPure;

public class Game_Controller : MonoBehaviour {

	public Text[] buttonList;
	private string playerSide;

	public GameObject gameOverPanel;
	public Text gamOverText;

	[SerializeField]
	private int moveCount;

	public GameObject restarButton;

	void Awake()
	{
		gameOverPanel.SetActive (false);
		SetGameControllerReferenceOnButtons ();
		playerSide = "X";
		moveCount = 0;
		GamePad.SetVibration (PlayerIndex.One, 0.0f, 0.0f);
	}

	void SetGameControllerReferenceOnButtons()
	{
		for (int i = 0; i < buttonList.Length; i++) {
			buttonList [i].GetComponentInParent<TicTacToe> ().SetGameControllerReference (this);
		}
	}

	public string GetPlayerSide()
	{
		return playerSide;
	}

	public void EndTurn()
	{
		moveCount++;
		if (buttonList [0].text == playerSide && buttonList [1].text == playerSide && buttonList [2].text == playerSide) {
			GameOver ();
		}
		if (buttonList [3].text == playerSide && buttonList [4].text == playerSide && buttonList [5].text == playerSide) {
			GameOver ();
		}
		if (buttonList [6].text == playerSide && buttonList [7].text == playerSide && buttonList [8].text == playerSide) {
			GameOver ();
		}
		if (buttonList [0].text == playerSide && buttonList [3].text == playerSide && buttonList [6].text == playerSide) {
			GameOver ();
		}
		if (buttonList [1].text == playerSide && buttonList [4].text == playerSide && buttonList [7].text == playerSide) {
			GameOver ();
		}
		if (buttonList [2].text == playerSide && buttonList [5].text == playerSide && buttonList [8].text == playerSide) {
			GameOver ();
		}
		if (buttonList [0].text == playerSide && buttonList [4].text == playerSide && buttonList [8].text == playerSide) {
			GameOver ();
		}
		if (buttonList [2].text == playerSide && buttonList [4].text == playerSide && buttonList [6].text == playerSide) {
			GameOver ();
		}

		if (moveCount >= 9) {
			GameOver ();
		}

		ChangeSiders ();
	}

	void GameOver()
	{
		SetBoardInteractable (false);

		SetGameOver ((playerSide == "X") ? "You Win" : ((moveCount >= 9) ? "It's a draw!" : "You Lose"));
	}

	void ChangeSiders()
	{
		playerSide = (playerSide == "X") ? "O" : "X";
	}

	void SetGameOver(string value)
	{
		gameOverPanel.SetActive (true);
		gamOverText.text = value;
	}

	public void RestartGame()
	{
		playerSide = "X";
		moveCount = 0;
		gameOverPanel.SetActive (false);
	

		SetBoardInteractable (true);

		for (int i = 0; i < buttonList.Length; i++) {
			buttonList [i].text = "";
		}
	}

	void SetBoardInteractable(bool toggle)
	{
		for (int i = 0; i < buttonList.Length; i++) {
			buttonList [i].GetComponentInParent<Button> ().interactable = toggle;
		}
	}

	public void ExitScene()
	{
		SceneManager.LoadScene (1);
	}
}
