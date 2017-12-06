using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float maxHealth = 10;
	public GameObject explosionFX;

	private float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	void Update(){
	}


	public void destroyPlayer() {
		Instantiate (explosionFX, transform.position, transform.rotation);
		Destroy (gameObject);
	}

	public void addDamage(float damage) {
		currentHealth -= damage;
		if (currentHealth <= 0) {
			destroyPlayer ();
		}
	}
}
