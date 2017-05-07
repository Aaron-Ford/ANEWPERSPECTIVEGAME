using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (buttonName: "Reset")) {
			SceneManager.LoadScene ("Working2");
			Time.timeScale = 1;
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Reset")
			SceneManager.LoadScene ("Working2");
	}
}
