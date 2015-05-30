using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Menu : MonoBehaviour {

	public Button startButton;
	public Button closeButton;
	public Text scoreOut;
	private static Menu _menu;
	private static List<int> scores = new List<int>();
	// Use this for initialization
	void Start () {
		startButton.onClick.AddListener (() => startGame ());
		closeButton.onClick.AddListener (() => quitGame ());
		_menu = this;
		printScores ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		Application.LoadLevel ("gameplay");
		ScoreManager.score = 0;
	}

	public void quitGame(){
		Application.Quit ();
	}

	private void printScores(){
		scoreOut.text = "";
		for (int i = scores.Count - 1; i >= 0;i--) {
			scoreOut.text += scores[i].ToString() + "\r\n"; 
		}
	}

	public static Menu menu{
		get{
			return _menu;
		}
	}

	public static void gameOver(int score)
	{
		scores.Add (score);
	}
}
