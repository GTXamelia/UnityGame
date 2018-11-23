using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 10;
	public int currentHealth;

	bool isDead;
	bool isSinking;

	void Awake()
	{
		currentHealth = startingHealth;
	}

	public void TakeDamage(int amount)
	{
		if (isDead)
			return;

		currentHealth -= amount;

		if (currentHealth <= 0)
		{
			Death();
		}
	}

	void Death()
	{
		isDead = true;
		Destroy(gameObject, 2f);
	}
}