using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaScript : MonoBehaviour
{
	public AudioClip eatClip;
	public int health = 25;

	private AudioSource playerAudio;
	private GameObject player;
	private PlayerHealth playerHealth;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		playerHealth.ClipPlay(eatClip);

		playerHealth.IncreaseHealth(health);

		gameObject.SetActive(false);
	}
}
