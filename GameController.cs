﻿using UnityEngine;
using System.Collections;

// Include the namespace required to use Unity UI
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Text scoreText;
	private int score;
	private int decimalScore;
	void Start ()
	{
		decimalScore = 10;
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}


	public void AddScore (int newScoreValue)
	{
		score += newScoreValue * decimalScore;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		// Update the text field of our 'scoreText' variable
		scoreText.text = "Score: " + score;
	}


}