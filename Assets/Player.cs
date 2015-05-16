using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private static Player _player;
	public GameObject bullet;
	private const float POWER = 50f;
	private const int ENERGY_DRAIN = 10;
	// Use this for initialization
	void Start () {
		_player = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isDead) {
			return;
		}
		if (Input.anyKeyDown && this.energy > ENERGY_DRAIN) {
			GameObject blt = (GameObject) Instantiate(bullet, transform.position, transform.rotation);
			blt.GetComponent<Rigidbody>().velocity = new Vector3(
				((Input.mousePosition.x/Screen.width)-0.5f)*POWER,
				((Input.mousePosition.y/Screen.height)-0.5f)*POWER, 
				28);
			this.energy -= ENERGY_DRAIN;
		}
	}

	public static Player player{
		get{
			return _player;
		}
	}

	public void getHit(int damage){
		this.life -= damage;
	}

	public int score{
		get{
			return ScoreManager.score;
		}
		set{
			ScoreManager.score = value;
		}
	}

	public int life{
		get{
			return LifeManager.life;
		}
		set{
			LifeManager.life = value;
		}
	}

	public int energy{
		get{
			return EnergyManager.energy;
		}
		set{
			EnergyManager.energy = value;
		}
	}

	public bool isDead{
		get{
			return this.life == 0;
		}
	}
}
