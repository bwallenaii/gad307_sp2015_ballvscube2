using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameObject particle;
	private const int NUM_PARTICLES = 8;
	// Use this for initialization
	void Start () {
		this.rb.velocity = new Vector3 (Random.Range(-5, 5), Random.Range(-1, 10), -28);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "BackWall") {
			this.die();
			Player.player.getHit();
		}
	}

	public Rigidbody rb{
		get{
			return this.gameObject.GetComponent<Rigidbody>();
		}
	}

	public void die(){
		Destroy (this.gameObject);
		for (int i = 0; i < NUM_PARTICLES; ++i) {
			Instantiate(particle, this.transform.position, this.transform.rotation);
		}
	}
}
