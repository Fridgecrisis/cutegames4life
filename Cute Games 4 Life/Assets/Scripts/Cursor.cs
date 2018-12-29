using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

	Vector3 startPosition;
	Vector3 endPosition;
	float speed;
	float distance;
	float startTime;

	// Use this for initialization
	void Start () {
		
		startTime = Time.time;
		speed = 500.0F;
		distance = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.position = destinationPosition;
		float distanceCovered = (Time.time - startTime) * speed;
		float fractionMoved;
		if (distance == 0) {
			fractionMoved = 1.0F;
		} else {
			fractionMoved = distanceCovered / distance;
		}
		transform.position = Vector3.Lerp(startPosition, endPosition, fractionMoved);
		
	}
	
	public void SetNewDestination (Vector3 newPosition) {
		
		startTime = Time.time;
		startPosition = transform.position;
		endPosition = newPosition;
		distance = Vector3.Distance(startPosition, endPosition);
		
	}
}
