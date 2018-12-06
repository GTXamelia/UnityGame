using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
	// Private variables
	private GameObject player;
	private PlayerHealth playerHealth;
	private EnemyHealth enemyHealth;
	private bool playerInRange;
	private float timer;

	// Public variables
	public float timeBetweenAttacks;
	public int attackDamage;

	// Ran once
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player"); // Get player object
		playerHealth = player.GetComponent<PlayerHealth>(); // Get PlayerHealth script component of player object
	}

	// Ran every frame
	void Update()
	{
		timer += Time.deltaTime; // Get time

		if (timer >= timeBetweenAttacks && playerInRange) // If player is in range and time from last attack is met
		{
			Attack(); // Run attack function
		}
	}

	// If object collides with enemy object
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player) // If object that collides is the player
		{
			playerInRange = true; // Player in range set to true
		}
	}

	// If object exits collision range of enemy object
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject == player) // If this object is the player 
		{
			playerInRange = false; // Set player in range to false
		}
	}

	// Function to attack player
	void Attack()
	{
		timer = 0f; // Set timer back to zero

		if (playerHealth.currentHealth > 0) // If players health is above 0
		{
			playerHealth.TakeDamage(attackDamage); // Damage player
		}
	}
}