using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

	GameObject mainUI;
	GameObject optionUI;

	void Start(){

	}


	public void OptionButton () {
		GameObject.Find("main_UI").SetActive (false);
		GameObject.Find("Option_UI").transform.Find("option_UI").gameObject.SetActive (true);
		
	}


	public void OptionBack () {
		GameObject.Find("option_UI").SetActive (false);
		GameObject.Find("Main_UI").transform.Find("main_UI").gameObject.SetActive (true);

	}

}
