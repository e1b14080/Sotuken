using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent : MonoBehaviour {

	GameObject ARcamera;

	// Use this for initialization
	void Start () {
		ARcamera = GameObject.Find("ARCamera");

		this.transform.parent = ARcamera.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
