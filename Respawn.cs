using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	private Vector3 startPos;
	private Quaternion startRot;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		startRot = transform.rotation;
	}
	
	//detect collision with trigger//
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "death") {
			transform.position = startPos;
			transform.rotation = startRot;
		}
	}
}
