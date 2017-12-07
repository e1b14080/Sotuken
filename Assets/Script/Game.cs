using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public GameObject correct;
	public int answer;
	int playnumber;

	// Use this for initialization
	void Start () {
		playnumber = 2;
	}
	
	// Update is called once per frame
	void Update () {

		if (playnumber == answer) {
			Instantiate (correct);
			playnumber = 1000;
		}
		
	}
}
