using UnityEngine;
using System.Collections;

public class DeadZoneCollission : MonoBehaviour {

	public GameObject respawnPrefab;
	private GameObject taxi;

	void OnCollisionEnter2D(Collision2D col) {
		if (col.collider.tag == "Player") {
			Destroy(GameObject.FindGameObjectWithTag (col.collider.tag));
			Instantiate(respawnPrefab, new Vector3 (respawnPrefab.transform.position.x, respawnPrefab.transform.position.y,0), Quaternion.identity);
		}

	}
}
