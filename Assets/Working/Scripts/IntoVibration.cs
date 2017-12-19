using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoVibration : MonoBehaviour {

    //めりこみ音
    private AudioSource _intoSound;
    //オーディオソースの番号
    [SerializeField]
    private int _sourceNumber = 0;

    private Rigidbody _rigid;
    //移動しているかを認める速度の定数
    const float MOVING_SPEED_LIMIT = 0.1f;



    // Use this for initialization
    void Start () {
        _rigid = GetComponent<Rigidbody>();
        //複数のオーディオソースを読み込む
        AudioSource[] audioSources = GetComponents<AudioSource>();
        //使用するオーディオソースの設定
        _intoSound = audioSources[_sourceNumber];
    }
	
    void OnTriggerStay(Collider other)
    {
        Debug.Log("speed:"+_rigid.velocity.magnitude);
        //オブジェクトの移動判断
        if (_rigid.velocity.magnitude >= MOVING_SPEED_LIMIT)
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
