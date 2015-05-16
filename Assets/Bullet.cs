using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject particle;
	private const int NUM_PARTICLES = 8;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.player.isDead) {
			this.die ();
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<Enemy> ()) {
			this.die ();
			col.gameObject.GetComponent<Enemy>().die ();
			Player.player.score += 1;
		}
		if (col.gameObject.GetComponent<Bullet> ()) {
			this.die ();
		}
	}

	public void die(){
		Destroy (this.gameObject);
		for (int i = 0; i < NUM_PARTICLES; ++i) {
			Instantiate(particle, this.transform.position, this.transform.rotation);
		}
	}
}
