using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {

	GameObject game_manager;
	Question _Question;

	GameObject setbutton;
	SetObject _SetObject;

	// Use this for initialization
	void Start () {

		setbutton = GameObject.Find ("Set");
		_SetObject = setbutton.GetComponent<SetObject> ();

		game_manager = GameObject.Find ("GameManager");

		_Question = game_manager.GetComponent<Question> ();

	}


	public void on_Next() {

		_Question.answer_time = false;

		GameObject[] boxes = GameObject.FindGameObjectsWithTag ("Box");

		foreach (GameObject box in boxes) {
			boxes [0].GetComponent<Transform> ().transform.position = new Vector3(100f,100f,100f);
			Destroy (box,1f);
		}

		StartCoroutine ("Setobject");

		
	}

	private IEnumerator Setobject(){
		yield return new WaitForSeconds (1.2f);
		_SetObject.Onclick1 ();
	}
}
