using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSlide : MonoBehaviour {

	GameObject answerPanel;

	void Start(){

	}

	//解答パネルの表示
	public void PanelOn () {
		answerPanel = GameObject.Find ("AnswerPanel");
			answerPanel.transform.localPosition = new Vector3 (-680, 0, 0);

	}

	//解答パネルの非表示
	public void PanelOff () {
		answerPanel = GameObject.Find ("AnswerPanel");
		answerPanel.transform.localPosition = new Vector3 (-1240, 0, 0);

	}
}
