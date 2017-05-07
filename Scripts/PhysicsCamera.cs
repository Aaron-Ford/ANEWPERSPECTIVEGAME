using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhysicsCamera : MonoBehaviour {

	public double xPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Camera.main.gameObject.transform.position.x > xPosition) 
			GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		
	}
}
