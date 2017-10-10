using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;

	// Create public variables for player speed, and for the Text UI game objects
	public float speed;

	// Use this for initialization
	void Start ()
	{

		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody> ();

		rb.velocity = transform.forward * speed;
	}
	

}
