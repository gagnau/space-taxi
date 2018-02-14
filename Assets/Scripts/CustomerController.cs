using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CustomerController : MonoBehaviour {

	private string currentPlatformTag = "-1";
	public string destinationPlatformTag = "-1";
	private List<string> platformList;

	// Use this for initialization
	void Start () {
		platformList = FindPlatformsTagsInLayer (LayerMask.NameToLayer ("Platform"));
	}
	
	void OnCollisionEnter2D(Collision2D other) {
		
		int layer = other.gameObject.layer;

		if (layer == LayerMask.NameToLayer ("Platform")) {

			if (destinationPlatformTag != other.gameObject.tag) {
				currentPlatformTag = other.gameObject.tag;

				FindDestinationTag ();
				//Debug.Log ("Player on platform: " + currentPlatformTag);
			} else {
				//We have reached our destination.
				//Call CustomerSpawner.removeCustomer() 
				//
				//Destroy (gameObject);
			}
		}
	}

	private void FindDestinationTag () {

		// Remove current tag
		Debug.Log ("Current platform: " + currentPlatformTag);
	
		platformList.Remove(currentPlatformTag);

		//Note that max is inclusive, so using Random.Range( 0.0f, 1.0f ) could return 1.0 as a value.
		int randomIndex = UnityEngine.Random.Range (0, platformList.Count-1);
		destinationPlatformTag = platformList[randomIndex];

		Debug.Log ("Target platform: " + destinationPlatformTag);
	}

	List<string> FindPlatformsTagsInLayer (int layer) { 

		GameObject[] goArray = FindObjectsOfType(typeof(GameObject)) as GameObject[]; 
		List<string> tagList = new List<string>(); 

		for (int i = 0; i < goArray.Length; i++) { 

			if (goArray[i].layer == layer) { 
				tagList.Add(goArray[i].tag); 
			} 
		} 

		if (tagList.Count == 0) { 
			Debug.Log ("!!! No platforms found in layer: " + layer);
			return null; 
		} 

		return tagList; 
	}
}
