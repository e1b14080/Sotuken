using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>、
/// プレイヤーの手が出題用オブジェクトのどのコライダーに触れているかを記憶するクラス。
/// プロパティを使用して読み書きをする。
/// こいつはシーン上で唯一無二の存在でなければならない。
/// </summary>

public class InvisibleObjColliderState : MonoBehaviour {
    [SerializeField]
    private bool _touchesOutsideCollider;
    [SerializeField]
    private bool _touchesInsideCollider;

    public bool TouchesOutsideCollider
    {
        get
        {
            return _touchesOutsideCollider;
        }
        set
        {
            _touchesOutsideCollider = value;
        }
    }

    public bool TouchesInsideCollider
    {
        get
        {
            return _touchesInsideCollider;
        }
        set
        {
            _touchesInsideCollider = value;
        }
    }

}
