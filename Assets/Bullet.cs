using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<Enemy> ()) {
			this.die ();
			col.gameObject.GetComponent<Enemy>().die ();
		}
		if (col.gameObject.GetComponent<Bullet> ()) {
			this.die ();
		}
	}

	public void die(){
		Destroy (this.gameObject);
	}
}
