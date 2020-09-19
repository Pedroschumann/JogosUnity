using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

	public Transform[] wayPoints;
	public float speed = 0.1f;

	private int cur = 0;

	void FixedUpdate() {
		if (transform.position.x != wayPoints [cur].position.x || transform.position.y != wayPoints [cur].position.y) {
			Vector2 p = Vector2.MoveTowards (transform.position,
				            wayPoints [cur].position,
				            speed);
			GetComponent<Rigidbody2D> ().MovePosition (p);
		} else {
			cur = (cur + 1) % wayPoints.Length;
		}
	}
}
