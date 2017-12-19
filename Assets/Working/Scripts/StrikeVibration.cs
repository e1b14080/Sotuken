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
    private AudioSource _strikeSound;
    //オーディオソースの番号
    [SerializeField]
    private int _sourceNumber = 0;
    // Use this for initialization
    void Start()
    {
        //複数のオーディオソースを読み込む
        AudioSource[] audioSources = GetComponents<AudioSource>();
        //使用するオーディオソースの設定
        _strikeSound = audioSources[_sourceNumber];
    }

    void OnTriggerEnter(Collider other)
    {
        //透明なオブジェクトに接触した瞬間に音を鳴らす。
        if (other.gameObject.tag == "InvisibleObject")
        {
            _strikeSound.Play();
            Debug.Log("Strike");
        }
    }
	
}
