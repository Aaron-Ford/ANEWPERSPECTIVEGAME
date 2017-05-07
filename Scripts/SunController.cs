using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour {

    public GameObject cube;
	public GameObject sphere;
	public float parallax;

    private float offset;

	// Use this for initialization
	void Start () {
		if (cube.activeInHierarchy == true) {
        	offset = transform.position.x - cube.transform.position.x;
		} else {
			offset = transform.position.x - sphere.transform.position.x;
		}
	}

	// Update is called once per frame
	void Update () {
		if (cube.activeInHierarchy == true) {
			transform.position = new Vector3 ((cube.transform.position.x + offset) * parallax, transform.position.y, transform.position.z);
		} else {
			transform.position = new Vector3 ((sphere.transform.position.x + offset) * parallax, transform.position.y, transform.position.z);
		}
	}
}
