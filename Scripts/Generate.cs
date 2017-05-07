using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public GameObject rn2;
	public GameObject rn3;
	public GameObject rn4;

	public string ResourceName2;
	public string ResourceName3;
	public string ResourceName4;

	// Use this for initialization
	void Start () {
		GameObject rn2 = Instantiate(Resources.Load(ResourceName2)) as GameObject;
		GameObject rn3 = Instantiate(Resources.Load(ResourceName3)) as GameObject;
		GameObject rn4 = Instantiate(Resources.Load(ResourceName4)) as GameObject;

	}
	// Update is called once per frame
	void Update () {
		
	}
}
