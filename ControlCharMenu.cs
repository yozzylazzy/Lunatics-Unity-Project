using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharMenu : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.C))
        {
			Time.timeScale = 0;
			Application.LoadLevelAdditiveAsync(2);
        }

	}
}
