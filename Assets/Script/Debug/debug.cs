using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour {

	int button =0;
	float countTime = 0;

	public void OnButton () {
		if (button == 0) {
			GameObject.Find ("Main_UI").transform.Find ("Times").gameObject.SetActive (true);
			button = 1;
		} else if (button == 1) {
			Time.timeScale = 0;
			button = 2;
		} else if (button == 2) {
			Time.timeScale = 1;
			button = 1;
		}
	}
	void FixedUpdate () {
		if (button == 1) {
			countTime += Time.deltaTime; //スタートしてからの秒数を格納
			if (countTime >= 20) {
				Time.timeScale = 0;
			}
		}
	}
}
