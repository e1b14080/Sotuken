using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 透明な立体物の外側をなぞっているときに音を鳴らす。
/// 
/// 使用するためには同オブジェクト内
/// にAudioSourceのコンポーネントを追加しておくこと。
/// </summary>
public class OutsideVibration : MonoBehaviour {

    //なぞり音
    AudioSource _rubSound;
    //最新の自身の位置
    Vector3 _latestPosition;
    //自身の位置が変化しているか
    bool _isMoving = false;

	// Use this for initialization
	void Start () {
        _rubSound = GetComponent<AudioSource>();
        //最新の位置の初期化
        _latestPosition = transform.position;
    }

    void OnTriggerStay(Collider other)
    {
        //透明な立体物の中を移動しているか
        if(_latestPosition != transform.position)
        {
            //移動している場合
            _isMoving = true;
            _latestPosition = transform.position;   //最新の位置の更新
            Debug.Log("isMoving");
        }else
        {
            //移動していない場合
            _isMoving = false;
            Debug.Log("isn`t Moving");
        }

        //透明な立体物の外側に触れているかつ、移動している場合
        if(other.gameObject.tag != "InsideCollider" && other.gameObject.tag == "OutsideCollider" && _isMoving == true)
        {
            if(!_rubSound.isPlaying)
                _rubSound.Play();
        }else
        {
            _rubSound.Pause();
        }

    }

}
