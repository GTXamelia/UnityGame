using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 10;
	public int currentHealth;
	
	bool isSinking;

	void Awake()
	{
		currentHealth = startingHealth;
	}

	void Update()
	{
		if (currentHealth <= 0)
		{
			Death();
		}
	}

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
	}

	void Death()
	{
		Destroy(gameObject);
	}
}