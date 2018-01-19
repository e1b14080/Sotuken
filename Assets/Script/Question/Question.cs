using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour {

	public GameObject[] invisible_Objects;
	public Sprite[] object_Sprites;
	private int question1=0;
	private int question2=0;

	private int sprites_lengs;

	private GameObject Answer1;

	public bool answer_time = true;

	// Use this for initialization
	void Start () {

		sprites_lengs = object_Sprites.Length;

		while(question1 == question2){
			question1 = Random.Range (0, sprites_lengs);
			question2 = Random.Range (0, sprites_lengs);
		}

		Debug.Log ("問題1は"+ question1);
		Debug.Log ("問題2は"+ question2);

		GameObject.Find ("answer1").GetComponent<Image> ().sprite = object_Sprites [question1];
		GameObject.Find ("answer2").GetComponent<Image> ().sprite = object_Sprites [question2];


	}
	
	// Update is called once per frame
	void Update () {

		if (answer_time == false) {
			question1 = 0;
			question2 = 0;

			while(question1 == question2){
				question1 = Random.Range (0, sprites_lengs);
				question2 = Random.Range (0, sprites_lengs);
			}

			GameObject.Find ("answer1").GetComponent<Image> ().sprite = object_Sprites [question1];
			GameObject.Find ("answer2").GetComponent<Image> ().sprite = object_Sprites [question2];

			answer_time = true;
		}


	}
}
