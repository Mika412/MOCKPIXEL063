using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour {

    public float size;
    public float moveSpeed = 1.0f;
    private Vector3 initSize;

    Manager mainMan;

    void Start() {
        initSize = transform.localScale;

		mainMan = GameObject.Find("ARCamera").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update() {
        if (mainMan.isFound) {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(size, size, size), Time.deltaTime * moveSpeed);
        } else {
            transform.localScale = initSize;
        }
    }
}
