using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjectReload : MonoBehaviour {

	public float xPosition;
	public float yPosition;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


void OnCollisionEnter2D(Collision2D coll)
{
	if (coll.gameObject.tag == "Checkpoint1")
			this.gameObject.transform.position = new Vector3(xPosition, yPosition, 0f);

}

}