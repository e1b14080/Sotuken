﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoVibration : MonoBehaviour {

    //めりこみ音
    private AudioSource _intoSound;
    //オーディオソースの番号
    [SerializeField]
    private int _sourceNumber = 0;

    //最新の自身の位置
    Vector3 _latestPosition;
    //自身の位置が変化しているか
    bool _isMoving = false;

    // Use this for initialization
    void Start () {
        //複数のオーディオソースを読み込む
        AudioSource[] audioSources = GetComponents<AudioSource>();
        //使用するオーディオソースの設定
        _intoSound = audioSources[_sourceNumber];

        //最新の位置の初期化
        _latestPosition = transform.position;
    }
	
    void FixedUpdate()
    {
        //透明な立体物の中を移動しているか
        if (_latestPosition != transform.position)
        {
            //移動している場合
            _isMoving = true;
            _latestPosition = transform.position;   //最新の位置の更新
            Debug.Log("Player's hand is Moving");
        }
        else
        {
            //移動していない場合
            _isMoving = false;
            Debug.Log("Player's hand isn't Moving");
        }
    }

    void OnTriggerStay(Collider other)
    {

        //オブジェクトの移動判断
        if (_isMoving)
        {
            Debug.Log("Move");
            //移動している場合
            
            if(other.gameObject.tag == "InvisibleObject")
            {
                //めり込み音が再生されていない場合
                if(!_intoSound.isPlaying)
                {
                    _intoSound.Play();
                }

            }else
            {
                _intoSound.Pause();
            }

        }else
        {
            Debug.Log("Stop");
            //移動していない場合
            _intoSound.Pause();
        }

    }

    void OnTriggerExit(Collider other)
    {
        _intoSound.Pause();
    }

}
