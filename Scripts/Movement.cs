using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed; // speed in meters per second
	public float minSpeed;
	public float maxSpeed;
	public float sprintAccelerate;
	public float sprintDeaccelerate;




    void Start() {
		} // Update is called once per frame 
    void FixedUpdate()
    {        
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
     
		if (Input.GetButton(buttonName: "Sprint")) {
			if (speed < maxSpeed) {
				speed = speed + sprintAccelerate;
			}
				transform.position += moveDir * speed * Time.deltaTime;
		
		} else {
			if (speed > minSpeed) {
				speed = speed - sprintDeaccelerate;
			}
			transform.position += moveDir * speed * Time.deltaTime;
		
		}

	
    }

	void Update(){

	}



		





}
