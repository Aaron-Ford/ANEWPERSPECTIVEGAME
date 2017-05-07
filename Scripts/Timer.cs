using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	private bool finished = false;
	private string min;
	private string sec;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (finished)
			return;
		
		float t = Time.time - startTime;
		if (((int)t / 60) < 1) {
			min = ("");
		} else {
			min = ((int)t / 60).ToString ("d2");
			min = (min + ":");
		}

		if ((t % 60) < 10) {
			sec = (t % 60).ToString ("f2");
			sec = ("0" + sec);
		} else {
			sec = (t % 60).ToString ("f2");
		}
		timerText.text = min + sec;
	}

	public void Finish()
	{
		finished = true;
		timerText.color = Color.yellow;

	}
}
