using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnoControl : MonoBehaviour {

	public Animator anim;
	public Rigidbody rbody;

	private float InputH;
	private float InputV;
	private bool run;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody> ();
		run = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("1")) {
			anim.Play ("WAIT01", -1, 0f);
		}
		if (Input.GetKeyDown ("2")) {
			anim.Play ("WAIT02", -1, 0f);
		}
		if (Input.GetKeyDown ("3")) {
			anim.Play ("WAIT04", -1, 0f);
		
		}

		if (Input.GetKey (KeyCode.LeftShift)) {
			run = true;
		} else {
			run = false;
		}
		if (Input.GetKey (KeyCode.Space)) {
			anim.SetBool ("jump", true);
		} else {
			anim.SetBool ("jump", false);
		}

		InputH = Input.GetAxis("Horizontal");
		InputV = Input.GetAxis("Vertical");

		anim.SetFloat("InputH",InputH);
		anim.SetFloat("InputV",InputV);
		anim.SetBool ("run", run);

		float moveX = InputH * 20f * Time.deltaTime;
		float movez = InputV * 50f * Time.deltaTime;

		if (movez <= 0f) {
			moveX = 0f;
		} else if (run)
		{
			moveX *= 3f;
			movez *= 3f;
		}


		rbody.velocity = new Vector3(moveX,0f,movez);
	}


}

