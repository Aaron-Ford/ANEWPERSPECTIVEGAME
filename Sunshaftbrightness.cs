using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Sunshaftbrightness : MonoBehaviour {

	private float temp;
	// Use this for initialization
	void Start () {
		GetComponent<SunShafts> ().sunShaftIntensity = 1.15f;
		temp = 1.15f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (GetComponent<SunShafts> ().sunShaftIntensity > 0) {
			temp = temp - .0005f;
			GetComponent<SunShafts> ().sunShaftIntensity = temp;
		}
	}
}
