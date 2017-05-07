using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

	private float temp;
	// Use this for initialization
	void Start () {
		temp = 0;
	}
	
	// Update is called once per frame
	void Update () {
		temp = temp + .1f;
		transform.position = new Vector3 (temp,transform.position.y, transform.position.z);
	}
}
