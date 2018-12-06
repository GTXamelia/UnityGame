using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	// Private variables
	private bool activated;
	private GameObject clone;
	private GameObject[] OBCount;

	// Public variables
	public GameObject enemy;
	public Transform[] spawnPoints;
	public GameObject ColliderLeft;
	public GameObject ColliderRight;

	// Ran once
	void Awake()
	{
		OBCount = GameObject.FindGameObjectsWithTag("Enemies"); // Get all objects with tag 'Enemies'
	}

	// Ran each frame
	void Update()
	{
		OBCount = GameObject.FindGameObjectsWithTag("Enemies"); // Get all objects with tag 'Enemies'

		if (OBCount.Length <= 0) // If array is less than or equal to zero
		{
			// Deactivate colliders
			ColliderLeft.SetActive(false);
			ColliderRight.SetActive(false);
		}
		else
		{
			// Deactivate colliders
			ColliderLeft.SetActive(true);
			ColliderRight.SetActive(true);
		}
	}

	// Collision detection
	void OnTriggerEnter2D(Collider2D col)
	{
		if (this.activated == false) // While this is inactive
		{
			StartCoroutine(SpawnAsync()); // Run async function to spawn enemies

			this.activated = true; // activate object
		}
	}

	// Async function responisble for spawning enemies
	IEnumerator SpawnAsync()
	{
		for (int i = 0; i < 5; i++) // Runs 5 times for a total of 10 enemies
		{
			clone = Instantiate(enemy, spawnPoints[0].position, transform.rotation); // Clone enemy object
			clone.tag = "Enemies"; // Set tag to Enemies
			clone = Instantiate(enemy, spawnPoints[1].position, transform.rotation); // Clone enemy object
			clone.tag = "Enemies";// Set tag to Enemies

			yield return new WaitForSeconds(3.0f); // Wait 3 seconds
		}
	}
}