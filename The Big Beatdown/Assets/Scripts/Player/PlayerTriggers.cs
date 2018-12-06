using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
	// Collision detection
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemies" || col.gameObject.tag == "Boss") // If the object has a tag of 'Enemies' or 'Boss'
		{
			EnemyHealth enemyHealth = col.GetComponent<EnemyHealth>(); // Get EnemyHealth script of colliding object 
			enemyHealth.TakeDamage(10); // Give object 10 damage
		}
	}
}
