﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

	private Vector3 startPos;
	private float repeatWidth;

	private void Start()
	{
		startPos = transform.position; // Establish the default starting position 
		repeatWidth = GetComponent<BoxCollider>().size.z*300/ 2; // Set repeat width to half of the background
	}

	private void Update()
	{
		// If background moves left by its repeat width, move it back to start position
		if (transform.position.z < startPos.z - repeatWidth)
		{
			transform.position = startPos;
		}
	}


}


