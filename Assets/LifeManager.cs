using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeManager : MonoBehaviour {

	private static Slider slider;
	// Use this for initialization
	void Start () {
		slider = this.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static int life{
		get{
			return (int) slider.value;
		}set{
			slider.value = value < 0 ? 0:value;
			slider.value = slider.value > 100 ? 100:slider.value;
		}
	}
}
