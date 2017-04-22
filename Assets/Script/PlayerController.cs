using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed;
	public float tilt;

	void Start() {

		rb = GetComponent<Rigidbody>();

	}

	void FixedUpdate() {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.velocity = (movement * speed);


		rb.rotation = Quaternion.Euler (0.0f, 0.0f, (rb.velocity.x * -tilt));
	}
}