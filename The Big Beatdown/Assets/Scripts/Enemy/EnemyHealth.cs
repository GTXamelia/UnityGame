using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 10;
	public int currentHealth;

	GameObject text;
	UIText uiText;

	void Awake()
	{
		currentHealth = startingHealth;

		text = GameObject.Find("Text");
		uiText = text.GetComponent<UIText>();
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
		uiText.score(10);

		Destroy(gameObject);
	}
}