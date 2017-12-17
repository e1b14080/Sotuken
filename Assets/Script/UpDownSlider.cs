using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpDownSlider : MonoBehaviour {

	private Slider slider;
	private float level;
	GameObject hand;

	void Start () {
		slider = GetComponent<Slider>();
		slider.value = 0;
		hand = GameObject.Find("Hand");
	}

	void Update (){
		hand.transform.position = new Vector3 (0, slider.value, 0);

		}
}