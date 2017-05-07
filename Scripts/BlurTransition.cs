using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;


public class BlurTransition : MonoBehaviour {

	private float delay;
	private float increase = .01f;
	private float increase1 = .1f;
	private float count = 999999f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (buttonName: "Switch")) {
			GetComponent<DepthOfField> ().enabled = true;
			GetComponent<BlurOptimized> ().enabled = true;
			GetComponent<DepthOfField> ().aperture = 1.0f;
			count = Time.time + .01f;
			transition ();



			//delay = Time.time + 1.0f;
		}
		//if (Time.time > delay)
		//	GetComponent<BlurOptimized> ().enabled = false;




	}

	private void transition(){
		for (int i = 1; i > 0; i++){
		while (Time.time > count && GetComponent<DepthOfField> ().aperture > .01f) {
			GetComponent<DepthOfField> ().aperture = GetComponent<DepthOfField> ().aperture - increase;
			GetComponent<BlurOptimized> ().blurSize = GetComponent<BlurOptimized> ().blurSize - increase1;
			count = Time.time + .01f;
		}


		if (Time.time > count && GetComponent<DepthOfField> ().aperture <= .01f)  {
			GetComponent<DepthOfField> ().enabled = false;
			GetComponent<BlurOptimized> ().enabled = false;
				i = -1;
		}
		
		}
	}
}
