using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {

	public GameObject cube;
	public GameObject sphere;


	void Start () {
		
	}
	

	void Update () {

		if (Input.GetButtonDown(buttonName: "Switch"))
		{
			if (cube.activeInHierarchy == true) {
				sphere.SetActive (true);
				sphere.GetComponent<Rigidbody2D> ().velocity = cube.GetComponent<Rigidbody2D> ().velocity;
				sphere.transform.position = cube.transform.position;
				cube.SetActive (false);

			} else {
				cube.SetActive (true);
				cube.GetComponent<Rigidbody2D> ().velocity = sphere.GetComponent<Rigidbody2D> ().velocity;
				cube.transform.position = sphere.transform.position;
				sphere.SetActive (false);
			}
		}
	}
}
