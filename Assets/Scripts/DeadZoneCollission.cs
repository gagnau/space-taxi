using UnityEngine;
using System.Collections;
using System;

public class DeadZoneCollission : MonoBehaviour {

	public GameObject respawnPrefab;
	private GameObject taxi;

	void OnCollisionEnter2D(Collision2D col) {
		if (col.collider.tag == "Player") {

			PlayerHealth playerHealth = col.gameObject.GetComponent<PlayerHealth> ();//GameObject.FindGameObjectWithTag (col.collider.tag).GetComponent<PlayerHealth>();
			playerHealth.addDamage (200);
			Invoke ("RespawnPlayer", 2);

		}
	}

	void RespawnPlayer() {
		GameObject newPlayer = Instantiate (respawnPrefab, new Vector3 (respawnPrefab.transform.position.x, respawnPrefab.transform.position.y, 0), Quaternion.identity);
		CameraController cc = Camera.main.GetComponent<CameraController> ();
		cc.resetCamera (newPlayer.transform);
	}
}
