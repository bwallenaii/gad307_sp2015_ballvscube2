using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	private static int _score = 0;
	private Text text;
	// Use this for initialization
	void Start () {
		this.text = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.text.text = "Score: " + _score;
	}

	public static int score{
		get{
			return _score;
		}
		set{
			if(value > 0)
			{
				_score = value;
			}
			else{
				_score = 0;
			}
		}
	}
}
