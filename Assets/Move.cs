using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private Rigidbody2D rb;
	public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float vertical = Input.GetAxis("Vertical");
		float horizontal = Input.GetAxis("Horizontal");
		Vector2 movement = new Vector2(horizontal, vertical);
		movement = movement.normalized * moveSpeed;

		rb.AddForce(movement);
	}
}
