using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour {
	public Transform[] spawnPoints;
	public GameObject customer;
	public int maxCustomers;
	private int currentCustomers;

	// Use this for initialization
	void Start () {
		currentCustomers = 0;
		this.Spawn ();
	}
	
	void FixedUpdate () {
		if (currentCustomers <= maxCustomers) {
			Spawn ();
		}
	}

	void Spawn ()
	{
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (customer, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		currentCustomers++;
	}

	public void removeCustomer() {
		currentCustomers--;
	}
}
