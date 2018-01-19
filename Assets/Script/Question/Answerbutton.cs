using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answerbutton : MonoBehaviour {


	GameObject game_manager;
	Question _Question;

	private AudioSource correct;
	private AudioSource incorrect;

	// Use this for initialization
	void Start () {

		game_manager = GameObject.Find ("GameManager");
		_Question = game_manager.GetComponent<Question> ();

	}

	public void on_answer1 () {

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		correct = audioSources [0];
		incorrect = audioSources [1];
		
		if (_Question.correct == 1) {
			correct.PlayOneShot (correct.clip);
		} else {
			incorrect.PlayOneShot (incorrect.clip);
		}
	}


	public void on_answer2 () {

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		correct = audioSources [0];
		incorrect = audioSources [1];

		if (_Question.correct == 2) {
			correct.PlayOneShot (correct.clip);
		} else {
			incorrect.PlayOneShot (incorrect.clip);
		}
	}
}
