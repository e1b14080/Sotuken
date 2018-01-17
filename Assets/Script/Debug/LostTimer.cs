using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LostTimer : MonoBehaviour {

	float countTime = 0;
	public bool lost = true;
	GameObject hand;
	GameObject lostcount;
	int lostCount = 0;
	bool lostCounter = true;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		if (GameObject.Find ("HandTarget").GetComponent<Rigidbody> ().IsSleeping ()) {
			lost = true;
			if (lostCounter) {
				lostCount++;
				lostCounter = false;
			}
		} else {
			lost = false;
			lostCounter = true;
		}

		GameObject.Find ("LostCount").GetComponent<Text> ().text = lostCount.ToString();


		if(lost == true){
			countTime += Time.deltaTime; //スタートしてからの秒数を格納
			GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示
		}
	}
}