﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchesInvisibleObjCollider : MonoBehaviour {

    public enum TouchesCollider { OutsideCollider,InsideCollider };

    public TouchesCollider touchesCollider = TouchesCollider.OutsideCollider;
    private InvisibleObjColliderState _invisibleObjColliderState;
    private StrikeVibration _strikeVibration;
    static private int _intoOutsideColliderCount = 0;
    static private int _intoInsideColliderCount = 0;

	// Use this for initialization
	void Start () {
        GameObject _colliderStateManager = GameObject.Find("ColliderStateManager");
        GameObject _handController = GameObject.Find("VibrationEffect");
        _invisibleObjColliderState = _colliderStateManager.GetComponent<InvisibleObjColliderState>();
        _strikeVibration = _handController.GetComponent<StrikeVibration>();
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            if (touchesCollider == TouchesCollider.OutsideCollider)
            {
                _intoOutsideColliderCount++;
                _invisibleObjColliderState.TouchesOutsideCollider = true;
            }

            if (touchesCollider == TouchesCollider.InsideCollider)
            {
                _intoInsideColliderCount++;
                _invisibleObjColliderState.TouchesInsideCollider = true;
            }

            if (_intoOutsideColliderCount == 1)
            {
                _strikeVibration.PlayStrikeVibration();
            }

        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hand")
        {
            if (touchesCollider == TouchesCollider.OutsideCollider)
            {
                _invisibleObjColliderState.TouchesOutsideCollider = true;
            }

            if (touchesCollider == TouchesCollider.InsideCollider)
            {
                _invisibleObjColliderState.TouchesInsideCollider = true;
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Hand")
        {
            if (touchesCollider == TouchesCollider.OutsideCollider)
            {
                _intoOutsideColliderCount--;
                _invisibleObjColliderState.TouchesOutsideCollider = false;
            }

            if (touchesCollider == TouchesCollider.InsideCollider)
            {
                _intoInsideColliderCount--;
                _invisibleObjColliderState.TouchesInsideCollider = false;
            }

            //音を鳴らすスクリプト
            if (_intoInsideColliderCount == 0)
            {
                _strikeVibration.PlayStrikeVibration();
            }

        }
    }

}
