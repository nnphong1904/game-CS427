using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class megaman_jump : MonoBehaviour {
    public float jumpPower;
    GameObject obj;
    public Collider coll;
    // Start is called before the first frame update
    void Start () {
        obj = gameObject;
        coll = GetComponent<Collider> ();
        coll.isTrigger = true;
    }

    // Update is called once per frame
    void Update () {
        float currentY = obj.transform.position.y;
        if (Input.GetButtonDown ("Jump") && currentY < 3) {
            obj.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpPower));
        }
    }
    void OnTriggerEnter (Collider other) {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
    }
}