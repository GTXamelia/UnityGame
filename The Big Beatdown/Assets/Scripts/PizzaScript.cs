using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaScript : MonoBehaviour {

	public AudioClip eatClip;

	AudioSource playerAudio;
	GameObject player;
	PlayerHealth ClipPlay;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		ClipPlay = player.GetComponent<PlayerHealth>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		ClipPlay.ClipPlay(eatClip);
	}
}
