using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {

	GameObject game_manager;
	Question _Question;

	// Use this for initialization
	void Start () {

		game_manager = GameObject.Find ("GameManager");

		_Question = game_manager.GetComponent<Question> ();

	}


	public void on_Next() {

		_Question.answer_time = false;
		
	}
}
