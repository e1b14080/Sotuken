using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleSlider : MonoBehaviour {

	private Slider slider;
	private float level;
	GameObject hand;


	//Handtagを持つオブジェクトを、スライダーで拡大縮小させる。
	void Start () {
		slider = GetComponent<Slider>();
		slider.value = 1;
		hand = GameObject.FindWithTag("Hand");
	}

	void Update (){
		hand.transform.localScale = new Vector3 (slider.value, slider.value, slider.value);

	}
}
