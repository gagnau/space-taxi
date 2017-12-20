using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectSpawner : MonoBehaviour {

	public GameObject customer;                // The customer prefab to be spawned.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	private string eventNameString = "Spawn";
	private UnityAction callback;
	private UnityAction eventListener;

	// Use this for initialization
	void Start () {
		callback = new UnityAction (Spawn);
		EventManager.StartListening (eventNameString, callback);
	}

	void Spawn ()
	{
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (customer, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}

	void OnDestroy() {
		EventManager.StopListening (eventNameString,callback);

	}
}
