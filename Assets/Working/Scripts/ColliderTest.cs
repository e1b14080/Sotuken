using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //透明なオブジェクトに接触した瞬間に音を鳴らす。
        if (other.gameObject.tag != "OutsideCollider")
        {
            Debug.Log("Hit");
        }
    }
}
