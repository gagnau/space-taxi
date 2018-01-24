using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerController : MonoBehaviour {

	private string currentTag = "";


	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other) {
		
		int layer = other.gameObject.layer;

		if (layer == LayerMask.NameToLayer ("Platform")) {
			currentTag = other.gameObject.tag;

			Debug.Log ("Player on platform: " + currentTag);
		}
	}
}
