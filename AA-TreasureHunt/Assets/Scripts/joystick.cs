using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick : MonoBehaviour {


    protected Joystick jstick;

	// Use this for initialization
	void Start () {
        jstick = FindObjectOfType<Joystick>();
	}
	
	// Update is called once per frame
	void Update () {
        var rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(jstick.Horizontal * 10f, rb.velocity.y, jstick.Vertical * 10f);
	}
}
