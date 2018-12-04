using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaScript : MonoBehaviour {

	public AudioClip eatClip;

	AudioSource playerAudio;

	void OnTriggerEnter2D(Collider2D col)
	{
		playerAudio = GetComponent<AudioSource>();

		playerAudio.clip = eatClip;

		playerAudio.Play();
	}
}
