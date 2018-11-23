using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour {

	void Awake()
	{

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		EnemyHealth enemyHealth = col.GetComponent<EnemyHealth>();
		enemyHealth.TakeDamage(10);
		//Debug.Log("Trigger1 collided with " + col.name);
	}
}
