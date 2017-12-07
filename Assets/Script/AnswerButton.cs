using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour {

	public int answer = 0;
	GameObject Answer;

	void Start(){
		Answer = GameObject.Find ("Gamemanager");


	}

	public void answer1(){
		Game _Game = Answer.GetComponent<Game> ();
		_Game.answer = 1;
	}

	public void answer2(){
		Game _Game = Answer.GetComponent<Game> ();
		_Game.answer = 2;
	}

	public void answer3(){
		Game _Game = Answer.GetComponent<Game> ();
		_Game.answer = 3;
	}

}
