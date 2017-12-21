using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpDownSlider : MonoBehaviour {

	private Slider slider;
	private float level;
	GameObject hand;
	float pos;

	void Start () {
		slider = GetComponent<Slider>();
		hand = GameObject.FindWithTag("Hand");
		slider.value = 0;
		pos = hand.transform.localPosition.y;
	}

	void Update (){
		hand.transform.position = new Vector3 (hand.transform.position.x,pos + slider.value, hand.transform.position.z);

		}
}