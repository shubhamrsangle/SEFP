using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Vector3 zero = new Vector3(0f, 0f, 0f);
	// Use this for initialization
	void Start () {
        offset = transform.position - zero;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = offset + player.transform.position;
	}
}

