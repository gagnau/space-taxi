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
		minX = -1000;
		minY = -1000;
		maxY = 1000;
		maxX = 1000;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 newPosition = targetTransform.position + offset;
		transform.position = Vector3.Lerp(transform.position, newPosition, smoothing*Time.deltaTime);

		// todo: if xmin etc...
	}
}
