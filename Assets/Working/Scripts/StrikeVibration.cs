using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 透明な立体物にぶつかったときに一度、接触音を鳴らす。
/// 
/// 使用するためには同オブジェクト内
/// にAudioSourceのコンポーネントを追加しておくこと。
/// </summary>

public class StrikeVibration : MonoBehaviour {

    //接触音
    AudioSource _strikeSound;

    // Use this for initialization
    void Start()
    {
        //音の初期化
        _strikeSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        //透明なオブジェクトに接触した瞬間に音を鳴らす。
        if (other.gameObject.tag == "OutsideCollider")
        {
            _strikeSound.Play();
            Debug.Log("Strike");
        }
    }
	
}
