using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaScript : MonoBehaviour
{
	// Private variables
	private AudioSource playerAudio;
	private GameObject player;
	private PlayerHealth playerHealth;

	// Public variables
	public AudioClip eatClip;
	public int health = 25;

	// Ran once
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player"); // Get player object
		playerHealth = player.GetComponent<PlayerHealth>(); // get PlayerHealth script component of player object
	}

	// Collision detection
	void OnTriggerEnter2D(Collider2D col)
	{
		playerHealth.ClipPlay(eatClip);// Run ClipPlay function of playerHealth with eatClip

		playerHealth.IncreaseHealth(health); // Increase health

		gameObject.SetActive(false); // Remove object from scene
	}
}
