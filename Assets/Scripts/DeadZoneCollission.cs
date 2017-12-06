using UnityEngine;
using System.Collections;

public class DeadZoneCollission : MonoBehaviour {

	public GameObject respawnPrefab;
	private GameObject taxi;

	void OnCollisionEnter2D(Collision2D col) {
		if (col.collider.tag == "Player") {

			PlayerHealth playerHealth = col.gameObject.GetComponent<PlayerHealth> ();//GameObject.FindGameObjectWithTag (col.collider.tag).GetComponent<PlayerHealth>();
			playerHealth.addDamage (200);

			Instantiate(respawnPrefab, new Vector3 (respawnPrefab.transform.position.x, respawnPrefab.transform.position.y,0), Quaternion.identity);
		}

	}
}
