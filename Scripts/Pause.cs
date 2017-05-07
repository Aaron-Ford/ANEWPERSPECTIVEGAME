using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	public Text textpause;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (buttonName: "Pause"))
		{
			if (Time.timeScale == 1)
			{
				textpause.gameObject.SetActive (true);
				textpause.text = "Paused.";
				Time.timeScale = 0;
			}
			else
			{
				textpause.gameObject.SetActive (false);
				Time.timeScale = 1;
			}
		}
	}
}
