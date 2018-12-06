using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
	// Public variable
	public GameObject BossCollider;

	// Ran once
	void start()
	{
		BossCollider.SetActive(true); // Activate boss Collider
	}

	// Collision detection
	void OnTriggerEnter2D(Collider2D col)
	{
		BossCollider.SetActive(false); // Set boss Collider to inactive (Boss is free to move)
	}
}
