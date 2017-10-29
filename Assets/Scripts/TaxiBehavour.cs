using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiBehavour : MonoBehaviour {
	public float maxSpeed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal"); // Pre defined in Edit -> Project settings -> Input
		float moveY = Input.GetAxis ("Vertical"); // Pre defined in Edit -> Project settings -> Input
		Vector2 force = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
		rb.AddForce (force);
	}
}
