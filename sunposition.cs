using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunposition : MonoBehaviour {
	private float temp;

	// Use this for initialization
	void Start () {
		this.gameObject.transform.position = new Vector3 (transform.position.x, 14.0f, transform.position.z);
		temp = 14.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(temp > -3.0f){
			temp = temp - .01f;
		} 
		this.gameObject.transform.position = new Vector3 (transform.position.x, temp, transform.position.z);

}

}