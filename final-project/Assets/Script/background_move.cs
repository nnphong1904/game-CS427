﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_move : MonoBehaviour {
    // Start is called before the first frame update
    public float moveSpeed;
    public float moveRange;
    private Vector3 oldPosition;
    private GameObject obj;
    void Start () {
        obj = gameObject;
        oldPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update () {
        obj.transform.Translate (new Vector3 (-1 * Time.deltaTime * moveSpeed, 0, 0));
        if (Vector3.Distance (oldPosition, obj.transform.position) >= moveRange) {
            obj.transform.position = oldPosition;
        }
    }
}