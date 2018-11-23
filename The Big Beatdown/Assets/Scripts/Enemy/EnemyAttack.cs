using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;

	GameObject player;
	GameObject health;
	PlayerHealth playerHealth;
	EnemyHealth enemyHealth;
	bool playerInRange;
	float timer;


	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();

		Debug.Log(player + " " + playerHealth);
	}



	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && playerInRange)
		{
			Attack();
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player)
		{
			playerInRange = true;
		}
	}


	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject == player)
		{
			playerInRange = false;
		}
	}


	void Attack()
	{
		timer = 0f;

		if (playerHealth.currentHealth > 0)
		{
			Debug.Log("Player hit");
			playerHealth.TakeDamage(attackDamage);
		}
	}
}