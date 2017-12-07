using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIslide : MonoBehaviour {

	// Use this for initialization
	public void OnClick1 () {

		iTween.MoveTo (this.gameObject, iTween.Hash ("y", 30f));
		
	}

	public void OnClick2 () {

		iTween.MoveTo (this.gameObject, iTween.Hash ("y", -32f));

	}

	public void upButton1 () {

		iTween.MoveTo (this.gameObject, iTween.Hash ("y", 300f));

	}
	public void upButton2 () {

		iTween.MoveTo (this.gameObject, iTween.Hash ("y",90f));

	}



	public void downButton1 () {

		iTween.MoveTo (this.gameObject, iTween.Hash ("y", 30f));

	}

	public void downButton2 () {

		iTween.MoveTo (this.gameObject, iTween.Hash ("y", -90f));

	}



}
