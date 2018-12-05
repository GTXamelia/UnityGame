using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemies")
		{
			EnemyHealth enemyHealth = col.GetComponent<EnemyHealth>();
			enemyHealth.TakeDamage(10);
		}
	}
}
