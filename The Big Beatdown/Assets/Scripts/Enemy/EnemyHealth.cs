using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	// Private variables
	private GameObject text;
	private UIText uiText;

	// Public variables
	public int startingHealth;
	public int currentHealth;

	// Ran once
	void Awake()
	{
		currentHealth = startingHealth; // Set current health as starting health

		text = GameObject.Find("Text"); // Get text object
		uiText = text.GetComponent<UIText>(); // Get UIText script component of text object
	}

	// Ran every frame
	void Update()
	{
		if (currentHealth <= 0) // If current health is less than or equal to 0
		{
			Death(); // Run kill function
		}
	}

	// Function for taking damage
	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
	}

	// Function for killing object
	void Death()
	{
		uiText.score(10); // Award player 10 points for killing object

		Destroy(gameObject); // Remove object from scene
	}
}