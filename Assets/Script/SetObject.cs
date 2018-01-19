using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObject : MonoBehaviour {

	GameObject target;
	public GameObject Question_Object;
	private bool on_box = false;


	// Use this for initialization
	void Start () {
		target = GameObject.Find("Target01");


	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Box") == null) {
			on_box = false;
		} else {
			on_box = true;
		}
	}

	public void Onclick1() {
		
		if (on_box == false) {
			Vector3 pos = target.transform.position;
			Quaternion rotation = target.transform.rotation;
			pos.y = +0f;

			Vector3 scale = Question_Object.transform.localScale;
			//pos.y +=(scale.y / 2);


			Instantiate (Question_Object, pos, rotation);
		}
	}

	public void Onclick2() {

		GameObject[] boxes = GameObject.FindGameObjectsWithTag ("Box");

		foreach (GameObject box in boxes) {
			Destroy (box);
		}
	}
}
