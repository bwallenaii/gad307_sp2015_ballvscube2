using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnergyManager : MonoBehaviour {
	
	private static Slider slider;
	private const int DELAY_TIME = 5;
	private int delay = DELAY_TIME;
	// Use this for initialization
	void Start () {
		slider = this.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.delay--;
		if (this.delay <= 0) {
			this.delay = DELAY_TIME;
			energy++;
		}
	}
	
	public static int energy{
		get{
			return (int) slider.value;
		}set{
			slider.value = value < 0 ? 0:value;
			slider.value = slider.value > 100 ? 100:slider.value;
		}
	}
}
