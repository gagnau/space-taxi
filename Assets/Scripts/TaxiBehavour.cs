using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiBehavour : MonoBehaviour {
	
	public float maxSpeed;
	public LayerMask platform;
	public Transform gearCheck;

	private Rigidbody2D rb;
	private bool facingRight;
	private bool gearDown = true;
	private bool isLanded = false;
	private float gearCheckRadius = 0.5f;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		facingRight = true;
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveX = isLanded ? 0 : Input.GetAxis ("Horizontal"); // Pre defined in Edit -> Project settings -> Input
		float moveY = Input.GetAxis ("Vertical"); // Pre defined in Edit -> Project settings -> Input
		anim.SetFloat("verticalSpeed", Mathf.Abs(moveY));
		anim.SetFloat("horizontalSpeed", Mathf.Abs(moveX));

		Vector2 force = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
		rb.AddForce (force);

		anim.SetBool("gearDown", Physics2D.OverlapCircle(gearCheck.position, gearCheckRadius, platform));

		// Flip the player in the right direction
		if (moveX < 0 && this.facingRight || moveX > 0 && !this.facingRight) {
			flip ();
		}
	}

	void flip() {
		Debug.unityLogger.Log ("Flippin");
		this.facingRight = !this.facingRight;
		transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, 1);
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.unityLogger.Log ("on enter");
		isLanded = (other.gameObject.layer == 8);
	}

	void OnCollisionExit2D(Collision2D other) {
		Debug.unityLogger.Log ("on enter");
		isLanded = !((other.gameObject.layer == 8) && isLanded);
	}
}
