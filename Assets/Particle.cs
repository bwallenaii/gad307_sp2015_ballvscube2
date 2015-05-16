 using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {

	private int lifeTime;
	// Use this for initialization
	void Start () {
		this.lifeTime = RDice.Roll (10, 3) * 60;
	}
	
	// Update is called once per frame
	void Update () {
		this.lifeTime--;
		if (this.lifeTime <= 0) {
			Destroy(this.gameObject);
		}
	}
}
