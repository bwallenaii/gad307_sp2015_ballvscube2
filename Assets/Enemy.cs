using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

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
		}
	}

	public Rigidbody rb{
		get{
			return this.gameObject.GetComponent<Rigidbody>();
		}
	}

	public void die(){
		Destroy (this.gameObject);
		print ("I hurt you!!");
	}
}
