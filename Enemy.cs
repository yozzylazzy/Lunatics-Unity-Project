using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
	public GameObject player;
	private NavMeshAgent   nav;
	private Animator anim;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
		nav.speed = 1.2f;
		anim.speed = 1.2f;
	}

	// Update is called once per frame
	void Update () {
		anim.SetFloat ("velocity", nav.velocity.magnitude);
		nav.SetDestination (player.transform.position);
		
	}
}
