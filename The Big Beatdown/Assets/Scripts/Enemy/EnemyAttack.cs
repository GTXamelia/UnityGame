using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
	private GameObject player;
	private PlayerHealth playerHealth;
	private EnemyHealth enemyHealth;
	private bool playerInRange;
	private float timer;

	public float timeBetweenAttacks;
	public int attackDamage;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
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
			playerHealth.TakeDamage(attackDamage);
		}
	}
}