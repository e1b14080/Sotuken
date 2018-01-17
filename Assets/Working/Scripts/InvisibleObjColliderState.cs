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
    [SerializeField]
    private bool _touchesInsideColliderStay;
    [SerializeField]
    private int _intoColliderCount;

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

    public bool TouchesInsideColliderStay
    {
        get
        {
            return _touchesInsideColliderStay;
        }
        set
        {
            _touchesInsideColliderStay = value;
        }

    }

    public int IntoColliderCount
    {
        get
        {
            return _intoColliderCount;
        }
        set
        {
            _intoColliderCount = value;
        }
    }

}
