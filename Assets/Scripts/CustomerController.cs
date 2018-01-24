using System;
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

			List<GameObject> platformList = FindGameObjectsWithLayer (layer);
			Debug.Log("Number of platforms: " + platformList.Count);
		}
	}
		

	List<GameObject> FindGameObjectsWithLayer (int layer) { 

		GameObject[] goArray = FindObjectsOfType(typeof(GameObject)) as GameObject[]; 
		List<GameObject> goList = new List<GameObject>(); 

		for (int i = 0; i < goArray.Length; i++) { 

			if (goArray[i].layer == layer) { 
				goList.Add(goArray[i]); 
			} 
		} 

		if (goList.Count == 0) { 
			return null; 
		} 

		return goList; 
	}
}
