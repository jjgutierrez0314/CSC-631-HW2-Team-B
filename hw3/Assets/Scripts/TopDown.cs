using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown : MonoBehaviour {
    // Start is called before the first frame update
    public Transform FollowTarget;
    public Vector3 TargetOffset;
    public float MoveSpeed = 5f;

    private Transform _myTransform;

    private void Start () {
        // Cache camera transform
        TargetOffset = new Vector3 (0f, 10f, -10f);
        _myTransform = transform;
    }

    public void SetTarget (Transform aTransform) {
        FollowTarget = aTransform;
    }

    public void Update () {
        if (Input.GetKey (KeyCode.T)) {
            TargetOffset = new Vector3 (0f, 40f, -30f);
        }
        if (Input.GetKey(KeyCode.Y)) {
            TargetOffset = new Vector3 (0f,10f,-10f);
        }
    }

    private void LateUpdate () {
        if (FollowTarget != null)
            _myTransform.position = Vector3.Lerp (_myTransform.position, FollowTarget.position + TargetOffset, MoveSpeed * Time.deltaTime);
    }

}