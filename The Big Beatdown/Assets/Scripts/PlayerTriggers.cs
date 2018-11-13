using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour {

	public GameObject trigger;

	void Awake()
	{
		Debug.Log("Awake");

		trigger = GameObject.Find("LevelsBubble");

		trigger.SetActive(false);
	}



	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("Trigger1 collided with " + col.name);
	}
}
