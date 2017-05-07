using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public GameObject raster;
	public string ResourceName;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown(buttonName: "Switch") || Input.GetMouseButtonDown(1))
        {
			GameObject raster = Instantiate(Resources.Load(ResourceName)) as GameObject;
          	raster.transform.position = gameObject.transform.position;
            

			foreach (Transform child in transform) {
				GameObject.Destroy (child.gameObject);
			}
			Destroy(gameObject);
        }
		
	}
}

