using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "Boundary"){

			return;//exit whitout Destroy
		}

		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
