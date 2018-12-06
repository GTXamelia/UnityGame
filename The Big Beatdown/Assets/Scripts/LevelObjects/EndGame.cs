using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	// Private variables
	private GameObject player;
	private PlayerHealth playerHealth;
	private GameObject score;
	private UIText uiText;
	private GameObject special;
	private UIButtons uiButtons;

	// Collision detection
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") // If the object colliding is the player
		{
			player = GameObject.FindGameObjectWithTag("Player"); // Get player object
			playerHealth = player.GetComponent<PlayerHealth>(); // Get PlayerHealth script of player object 

			score = GameObject.Find("Text"); // Get text object
			uiText = score.GetComponent<UIText>(); // Get UIText script of Text object 

			special = GameObject.FindWithTag("UI"); // Get UI object
			uiButtons = special.GetComponent<UIButtons>(); // Get UIButtons script of UI object 

			// Set variables in static class
			PlayerParams.health = playerHealth.currentHealth; 
			PlayerParams.score = uiText.scoreAmount;
			PlayerParams.special = uiButtons.specialCount;

			// Get current scene
			Scene scene = SceneManager.GetActiveScene();

			if (scene.name == "Level1") // If scene is Level1
			{
				SceneManager.LoadScene("Level2"); // Load scene Level2
			}
			else if (scene.name == "Level2") // If scene is Level2
			{
				SceneManager.LoadScene("Level3"); // Load scene Level3
			}
			else // Else player is done levels
			{
				SceneManager.LoadScene("Done"); // Load scene Done
			}
		}
	}
}
