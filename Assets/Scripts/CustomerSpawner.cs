using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour {
	public Transform[] spawnPoints;
	public GameObject customer;

	// Use this for initialization
	void Start () {
		Instantiate(customer, new Vector3 (spawnPoints[2].position.x, spawnPoints[2].position.y, 0), Quaternion.identity);
	}
	
	void FixedUpdate () {
		
	}
}
