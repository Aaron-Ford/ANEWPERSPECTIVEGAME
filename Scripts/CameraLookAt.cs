using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour {

	public Transform cube;
	public GameObject cubetest;
	public Transform sphere;

	void Update ()
	{
		if (cubetest.activeInHierarchy == true) {
			transform.LookAt (cube);
		} else {
			transform.LookAt (sphere);
		}
	}
}
