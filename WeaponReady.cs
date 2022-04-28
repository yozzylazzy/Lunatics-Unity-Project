using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponReady : MonoBehaviour {
	
	public GameObject WeaponPlayer;

	public Transform attach;
	public Transform positionIdle;
	public Transform Player;
	private Vector3 awal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			
			WeaponPlayer.transform.parent = attach.transform;
			transform.position = attach.position;
			 
		}

		if (Input.GetKeyUp (KeyCode.Mouse0)) {
			transform.position = positionIdle.position;
			transform.rotation = positionIdle.rotation;
			WeaponPlayer.transform.parent = Player.transform;
		}

	}
}
