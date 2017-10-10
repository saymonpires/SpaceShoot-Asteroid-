using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	// Create public variables for player speed, and for the Text UI game objects
	public float tumble;

	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.onUnitSphere * tumble;
	}
	

}
