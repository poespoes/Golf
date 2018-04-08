using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Vector3 rotateAxis = new Vector3();
    public float rotateSpeed = 100f;
    private bool swing;
    private bool swingBack;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)&& swing == false) {
            Debug.Log("swing!");
            swing = true;
        }
        if (swing == true) Swing();
	}

    /*private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            Debug.Log("WIN!");
        }
    }*/

    private void Swing() {
        if (swing == true && swingBack == false) {
            transform.Rotate(rotateAxis, rotateSpeed * Time.deltaTime);
        }
        //if rotation = n, then swingBack = true

        if (swing == true && swingBack == true) {
            transform.Rotate(rotateAxis, -rotateSpeed * Time.deltaTime);
        }
        /*if (swing == true && swingBack == true && rotation back to original){
            swingBack = false;
        }*/
    }
}
