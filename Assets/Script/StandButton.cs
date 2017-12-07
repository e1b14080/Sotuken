using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandButton : MonoBehaviour {


	public void Onclick1() {

		this.gameObject.transform.root.gameObject.SetActive (false);
	}


	public void Onclick2() {
		GameObject Check02 = GameObject.Find("Check02");

		this.gameObject.transform.root.gameObject.SetActive (false);
		Check02.SetActive (false);
	}


}
