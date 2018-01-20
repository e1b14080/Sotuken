using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObject : MonoBehaviour {

	GameObject target;//平面マーカー
	GameObject Q_Object;//問題用オブジェクトを1時格納
	public GameObject Question_Object;//現在の問題用の透明オブジェクトを格納
	private bool on_box = false;//シーン上にボックスtagのオブジェクトが存在するか


	// Use this for initialization
	void Start () {
		target = GameObject.Find("Target01");//平面マーカーを探索
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Box") == null) {//シーン上にBoxtagが存在するかどうか
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

			//平面マーカー上に問題用オブジェクトを生成
			Q_Object =　Instantiate (Question_Object,new Vector3(100f,100f,100f), rotation) as GameObject;
			Q_Object.transform.position = pos;
		}
	}

	public void Onclick2() {
		//Boxtagがあるか探索し、すべて削除する。
		GameObject[] boxes = GameObject.FindGameObjectsWithTag ("Box");
		foreach (GameObject box in boxes) {
			boxes [0].GetComponent<Transform> ().transform.position = new Vector3(100f,100f,100f);
			Destroy (box);
		}
	}
}
