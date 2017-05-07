using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startlevel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( (Input.GetButtonDown (buttonName: "Jump")) || (Input.GetButtonDown (buttonName: "Pause")))

			SceneManager.LoadScene ("Working2");

	}
}
