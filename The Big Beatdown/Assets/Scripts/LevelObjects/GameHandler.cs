using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
	// Private variables
	private GameObject player;
	private PlayerHealth playerHealth;
	private GameObject score;
	private UIText uiText;
	private GameObject special;
	private UIButtons uiButtons;

	// Ran once
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag("Player"); // Find player object by tag
		playerHealth = player.GetComponent<PlayerHealth>(); // Get PlayerHealth script component of player object

		score = GameObject.Find("Text"); // Find text object
		uiText = score.GetComponent<UIText>(); // Find UIText script of text object

		special = GameObject.FindWithTag("UI"); // Find UI object by tag
		uiButtons = special.GetComponent<UIButtons>(); // Get UIButtons script of UI object

		playerHealth.IncreaseHealth(PlayerParams.health); // Increase health using static class PlayerParams
		uiText.score(PlayerParams.score); // Set score using static class PlayerParams
		uiButtons.SpecialUp(PlayerParams.special); // Increment special count by PlayerParams
	}
}
