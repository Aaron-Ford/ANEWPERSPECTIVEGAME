using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	private Rigidbody2D playerRigidbody2D;

	public float jumpForce;
	private bool isJumping;
	private bool jump;
	public LayerMask groundlayer;


	// Use this for initialization
	void Start()
	{
		//jumpForce = 200;
		isJumping = false;
		playerRigidbody2D = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		if (jump) {		
			isJumping = true;
			jump = false;

		}


	}


	void Update(){
		if ((Input.GetMouseButtonDown (0) || Input.GetButtonDown (buttonName: "Jump")) /**&& !isJumping**/) {
		Vector2 position = transform.position;
		Vector2 direction = Vector2.down;
		float distance = 0.5f;



			Debug.DrawRay (position, direction, Color.green);
			RaycastHit2D hit = Physics2D.Raycast (position, direction, distance, groundlayer);
			position = new Vector3 (transform.position.x - 0.36f, transform.position.y, transform.position.z);
			Debug.DrawRay (position, direction, Color.green);
			RaycastHit2D hit2 = Physics2D.Raycast (position, direction, distance, groundlayer);
			position = new Vector3 (transform.position.x + 0.36f, transform.position.y, transform.position.z);
			Debug.DrawRay (position, direction, Color.green);
			RaycastHit2D hit3 = Physics2D.Raycast (position, direction, distance, groundlayer);
			if (hit.collider != null || hit2.collider != null || hit3.collider != null ){

			//jump = true;

				isJumping = true;
				playerRigidbody2D.AddForce (new Vector2 (0, jumpForce));
			}
		}
	}







	void OnCollisionEnter2D(Collision2D coll)
	{


		if (coll.gameObject.tag == "Reset")
			SceneManager.LoadScene ("Working2");

		if (coll.gameObject.tag == "Checkpoint1")
			transform.position = new Vector3 (15.4f, 1.9f, 0);

		if (coll.gameObject.tag == "Checkpoint2") {
			transform.position = new Vector3 (30.95f, 2.4f, 0);
			GameObject square = GameObject.Find ("SquareRoll3(Clone)");
			if (square != null) {
				square.transform.position = new Vector3 (49.9f, 7.9f, 0);
			}
			GameObject circle = GameObject.Find ("CircleRoll3(Clone)");
			if (circle != null) {
				circle.transform.position = new Vector3 (49.9f, 7.9f, 0);
				circle.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			}
		}
	}

}

