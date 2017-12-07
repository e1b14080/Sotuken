using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRight : MonoBehaviour {

	private	AudioSource	audioSource;		// AudioSorceを格納する変数の宣言.
	public	AudioClip	sound;				// 効果音を格納する変数の宣言.
		

	void Start () {
		audioSource			= gameObject.AddComponent< AudioSource >();	// AudioSorceコンポーネントを追加し、変数に代入.
		audioSource.clip	= sound;		// 鳴らす音(変数)を格納.
		audioSource.loop	= true;		// 音のループ
		audioSource.panStereo = 1;
	}



	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Box") {
			Debug.Log ("aaaaaa");
			collider.gameObject.GetComponent<Renderer> ().material.color = new Color (1, 0, 0, 0.5f);

			audioSource.Play();		// 音を鳴らす.
		}
	}

	void OnTriggerExit(Collider collider) {

		if (collider.gameObject.tag == "Box") {
			Debug.Log ("aaaaaa");
			collider.gameObject.GetComponent<Renderer> ().material.color = new Color (1, 1, 1, 0);
			audioSource.Stop();		// 音を止める
		}
		
	}


}
