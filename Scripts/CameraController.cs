using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject cube;
	public GameObject sphere;

    private Vector3 offset;

	private float hold;


	// Use this for initialization
	void Start () {
		if (cube.activeInHierarchy == true) {
			offset = transform.position - cube.transform.position;
		} else {
			offset = transform.position - sphere.transform.position;
		}
	}

	// Update is called once per frame
	void Update () {
		if (cube.activeInHierarchy == true) {
			hold = (cube.transform.position.y + offset.y) * 0.5f;
			transform.position = new Vector3 (cube.transform.position.x + offset.x, hold, transform.position.z);
		} else {
			hold = (sphere.transform.position.y + offset.y) * 0.5f;
			transform.position = new Vector3 (sphere.transform.position.x + offset.x, hold, transform.position.z);
		}
	}
}
