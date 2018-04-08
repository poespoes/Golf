using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
    private Rigidbody rb;
    GameObject club;
    bool moving;
    float timer;
    float winScreen;
    bool winState;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        club = GameObject.Find("Club");
        rb.velocity = new Vector3(0,0,0);
    }

    void Update() {
        if(moving == false) rb.velocity = new Vector3(2,0, 0);
        if(Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("menu");
        timer += Time.deltaTime;

        if(timer >= 7 && !winState) {
            Debug.Log("RESTART!");
            SceneManager.LoadScene("main");
        }
        if(winState == true) winScreen += Time.deltaTime;
        if(winScreen >= 5) SceneManager.LoadScene("win");
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("WIN!");
        winState = true;
        transform.parent = club.transform;
        rb.velocity = Vector3.zero;
        moving = true;

    }
}