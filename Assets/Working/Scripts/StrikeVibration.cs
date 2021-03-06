﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 透明な立体物にぶつかったときに一度、接触音を鳴らす。
/// 透明な立体物の表面をなぞっている時も鳴らす。
/// 
/// 使用するためには同オブジェクト内
/// にAudioSourceのコンポーネントを追加しておくこと。
/// </summary>

public class StrikeVibration : MonoBehaviour {

    //接触音
    private AudioSource _strikeSound;
    //接触振動
    private AudioSource _strikeVibration;
    //オーディオソースの番号
    [SerializeField]
    private int _soundSourceNumber = 0;

    //コライダーの接触状態を記憶しているコンポーネント
    InvisibleObjColliderState _myColliderState;

    //最後に接触振動音を鳴らした位置
    Vector3 _latestSoundPlayPosition;
    //鳴らす距離
    [SerializeField]
    float _soundPlayDistance = 0.01f;

    // Use this for initialization
    void Start()
    {
        //複数のオーディオソースを読み込む
        AudioSource[] audioSources = GetComponents<AudioSource>();
        //使用するオーディオソースの設定
        _strikeSound = audioSources[_soundSourceNumber];

        GameObject myColliderStateObj = GameObject.Find("ColliderStateManager");
        _myColliderState = myColliderStateObj.GetComponent<InvisibleObjColliderState>();

    }

    //void OnTriggerEnter(Collider other)
    //{
    //    //透明なオブジェクトに接触した瞬間に音を鳴らす。
    //    if (other.gameObject.tag == "OutsideCollider"
    //        && _myColliderState.TouchesOutsideCollider == false)
    //    {
    //        _strikeSound.Play();
    //        Debug.Log("Strike");
    //        _latestSoundPlayPosition = transform.position;
    //    }
    //}

    void FixedUpdate()
    {
        if(_myColliderState.TouchesOutsideCollider == true
            && _myColliderState.TouchesInsideCollider == false)
        {
            if (Vector3.Distance(_latestSoundPlayPosition, transform.position) >= _soundPlayDistance)
            {
                _strikeSound.Play();
                Debug.Log("Stay");
                _latestSoundPlayPosition = transform.position;

            }
        }
    }

    public void PlayStrikeVibration()
    {
        _strikeSound.Play();
        _latestSoundPlayPosition = transform.position;
    }

}
