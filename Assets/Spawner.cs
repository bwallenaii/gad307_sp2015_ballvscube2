using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject enemy;
	private int delayTime = 0;
	private const int MAX_DELAY = 180;
	private const int MIN_DELAY = 30;

	// Use this for initialization
	void Start () {
		resetDelay ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.player.isDead) {
			return;
		}
		this.delayTime--;
		if (this.delayTime <= 0) {
			this.resetDelay();
			GameObject en = Instantiate (enemy);
			en.transform.position = this.transform.position;
		}
	}

	private void resetDelay() {
		this.delayTime = Random.Range (MIN_DELAY, MAX_DELAY);
	}
}
