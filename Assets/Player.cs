using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private static Player _player;
	public GameObject bullet;
	private const float POWER = 50f;
	// Use this for initialization
	void Start () {
		_player = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			GameObject blt = (GameObject) Instantiate(bullet, transform.position, transform.rotation);
			blt.GetComponent<Rigidbody>().velocity = new Vector3(
				((Input.mousePosition.x/Screen.width)-0.5f)*POWER,
				((Input.mousePosition.y/Screen.height)-0.5f)*POWER, 
				28);
		}
	}

	public static Player player{
		get{
			return _player;
		}
	}

	public void getHit(){
	}

	public void addPoints(){
	}
}
