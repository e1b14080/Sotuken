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

	public int correct = 0;

	GameObject setbutton;
	GameObject resetbutton;
	SetObject _SetObject;
	SetObject _ResetObject;



	// Use this for initialization
	void Start () {

		setbutton = GameObject.Find ("Set");
		resetbutton = GameObject.Find ("Reset");
		_SetObject = setbutton.GetComponent<SetObject> ();
		_ResetObject = resetbutton.GetComponent<SetObject> ();

		sprites_lengs = object_Sprites.Length;

		while(question1 == question2){
			question1 = Random.Range (0, sprites_lengs);
			question2 = Random.Range (0, sprites_lengs);
		}

		correct = Random.Range (1, 3);

		Debug.Log ("問題1は"+ question1);
		Debug.Log ("問題2は"+ question2);

		GameObject.Find ("answer1").GetComponent<Image> ().sprite = object_Sprites [question1];
		GameObject.Find ("answer2").GetComponent<Image> ().sprite = object_Sprites [question2];


		if (correct == 1) {
			_SetObject.Question_Object = invisible_Objects [question1];
			_ResetObject.Question_Object = invisible_Objects [question1];
		} else if (correct == 2) {
			_SetObject.Question_Object = invisible_Objects [question2];
			_ResetObject.Question_Object = invisible_Objects [question2];
		}



	}
	
	// Update is called once per frame
	void Update () {

		if (answer_time == false) {
			question1 = 0;
			question2 = 0;

			correct = Random.Range (1, 3);
			Debug.Log ("こたえは" + correct);

			while(question1 == question2){
				question1 = Random.Range (0, sprites_lengs);
				question2 = Random.Range (0, sprites_lengs);
			}

			GameObject.Find ("answer1").GetComponent<Image> ().sprite = object_Sprites [question1];
			GameObject.Find ("answer2").GetComponent<Image> ().sprite = object_Sprites [question2];

			if (correct == 1) {
				_SetObject.Question_Object = invisible_Objects [question1];
				_ResetObject.Question_Object = invisible_Objects [question1];
			} else if (correct == 2) {
				_SetObject.Question_Object = invisible_Objects [question2];
				_ResetObject.Question_Object = invisible_Objects [question2];
			}

			answer_time = true;
		}


	}
}
