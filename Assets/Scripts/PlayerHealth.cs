using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float maxHealth;
	public GameObject explosionFX;

	private float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (currentHealth <= 0) {
			destroyPlayer ();
		}
	}

	public void destroyPlayer() {
		Instantiate (explosionFX, transform.position, transform.rotation);
		Destroy (gameObject);
	}

	public void addDamage(float damage) {
		currentHealth -= damage;
	}
}
