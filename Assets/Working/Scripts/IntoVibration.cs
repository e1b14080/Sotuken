using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoVibration : MonoBehaviour {

    //めりこみ音
    private AudioSource _intoSound;
    //オーディオソースの番号
    [SerializeField]
    private int _sourceNumber = 0;

    private Rigidbody _rigidbody; 

    // Use this for initialization
    void Start () {
        //複数のオーディオソースを読み込む
        AudioSource[] audioSources = GetComponents<AudioSource>();
        //使用するオーディオソースの設定
        _intoSound = audioSources[_sourceNumber];

        _rigidbody = GetComponent<Rigidbody>();

    }

    void OnTriggerStay(Collider other)
    {

        if(other.gameObject.tag == "InsideCollider")
        {

            if(!_rigidbody.IsSleeping())
            {
                //移動している場合

                //めり込み音が再生されていない場合
                if (!_intoSound.isPlaying)
                {
                    _intoSound.Play();
                }

            }else
            {
                //移動していない場合
                _intoSound.Pause();
            }

        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "InsideCollider")
        {
            _intoSound.Pause();
        }
    }

}
