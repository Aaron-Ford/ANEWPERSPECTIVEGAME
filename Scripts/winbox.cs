using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winbox : MonoBehaviour {
	public Text textfinish;
	void OnTriggerEnter2D(Collider2D other)
	{
		GameObject.Find ("Player").SendMessage ("Finish");
		textfinish.gameObject.SetActive (true);
		textfinish.text = "Congratulations!\nYou have beaten Level 1.\nPress 'Back' to restart.";
		Time.timeScale = 0;
		if(Input.GetButtonDown(buttonName: "Pause")){
			Time.timeScale = 1;
		}
	}
}
