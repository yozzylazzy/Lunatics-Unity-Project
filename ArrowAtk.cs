using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrowAtk : MonoBehaviour
{
	public Rigidbody a_body;
	public float speed = 13.0f;

	public Vector3 targetPos;
	[Tooltip("How high the arc should be, in units")]
	public float arcHeight = 1;
	Vector3 startPos;

	// Use this for initialization
	void Start()
	{
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		/*float x0 = startPos.x;
		float x1 = targetPos.x;
		float dist = x1 - x0;
		float nextX = Mathf.MoveTowards(transform.position.x, x1, speed * Time.deltaTime);
		float baseY = Mathf.Lerp(startPos.y, targetPos.y, (nextX - x0) / dist);
		float arc = arcHeight * (nextX - x0) * (nextX - x1) / (-0.25f * dist * dist);
		Vector3 nextPos = new Vector3(nextX, baseY + arc, transform.position.z);


		// Rotate to face the next position, and then move there
		transform.rotation = LookAt(nextPos - transform.position);
		transform.position = nextPos;

		// Do something when we reach the target
		if (nextPos == targetPos) Arrived();
		*/

		transform.Translate(Vector3.up * Time.deltaTime * speed);

	}

	void Arrived()
    {
		Destroy(this);
    }
	
	/*static Quaternion LookAt(Vector2 forward)
    {
		return Quaternion.Euler(0,0,Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg);
	}*/

	void OnCollisionEnter(Collision Collision)
	{
		if (Collision.collider.tag == "Enemy")
		{
			a_body.constraints = RigidbodyConstraints.FreezeAll;
			speed = 0;
			this.transform.parent = transform;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ground"))
		{
			Destroy(this);
		}
	}
}
