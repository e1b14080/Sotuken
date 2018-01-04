using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchesInvisibleObjCollider : MonoBehaviour {

    public enum TouchesCollider { OutsideCollider,InsideCollider };

    public TouchesCollider touchesCollider = TouchesCollider.OutsideCollider;
    public GameObject ColliderStateManager;
    private InvisibleObjColliderState _invisibleObjColliderState;

	// Use this for initialization
	void Start () {
        _invisibleObjColliderState = ColliderStateManager.GetComponent<InvisibleObjColliderState>();
	}

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Hand")
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
                _invisibleObjColliderState.TouchesOutsideCollider = false;
            }

            if (touchesCollider == TouchesCollider.InsideCollider)
            {
                _invisibleObjColliderState.TouchesInsideCollider = false;
            }
        }
    }

}
