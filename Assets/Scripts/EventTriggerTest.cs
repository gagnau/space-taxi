using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerTest : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown ("q"))
		{
			EventManager.TriggerEvent ("Spawn");
		}
	}
}