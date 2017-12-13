using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public Transform targetTransform;
	public float smoothing;

	private Vector3 offset;
	private float minY;
	private float maxY;
	private float minX;
	private float maxX;

	// Use this for initialization
	void Start () {
		offset = transform.position - targetTransform.position;
		minX = -13;
		maxX = 13;
		minY = -13;
		maxY = 13;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 newPosition = targetTransform.position + offset;

		Debug.unityLogger.Log (newPosition.y);

		if (newPosition.x > maxX || newPosition.x < minX) {
			newPosition.x = transform.position.x;
		}
	
		if (newPosition.y > maxY || newPosition.y < minY) {
			newPosition.y = transform.position.y;
		}

		transform.position = Vector3.Lerp (transform.position, newPosition, smoothing * Time.deltaTime);

		// todo: if xmin etc...
	}
}
