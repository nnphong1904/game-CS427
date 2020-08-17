using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class megaman_jump : MonoBehaviour {
    public float jumpPower;
    GameObject obj;
    public GameObject gameController;
    public bool isGrounded = true;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start () {
        obj = gameObject;
        if (gameController == null) {
            gameController = GameObject.FindGameObjectWithTag ("GameController");
        }
    }

    // Update is called once per frame
    void Update () {
        float currentY = obj.transform.position.y;
        if (Input.GetButtonDown ("Jump") && isGrounded) {
            isGrounded = false;
            obj.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpPower));
        }
        if (Input.GetButtonDown ("End") && currentY < 3) {
            gameController.GetComponent<GameController> ().EndGame ();
        }

    }
    void EndGame () {
        gameController.GetComponent<GameController> ().EndGame ();
    }
    private void OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.tag == "ground") {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D (Collision2D other) {
        if (other.gameObject.tag == "ground") {
            isGrounded = false;
        }
    }
}