using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
	private GameObject player;
	private PlayerHealth playerHealth;

	private GameObject score;
	private UIText uiText;

	private GameObject special;
	private UIButtons uiButtons;

	void Start ()
	{
		Debug.Log("Level2: Health (" + PlayerParams.health + ")");
		Debug.Log("Level2: Score (" + PlayerParams.score + ")");
		Debug.Log("Level2: Special (" + PlayerParams.special + ")");

		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();

		score = GameObject.Find("Text");
		uiText = score.GetComponent<UIText>();

		special = GameObject.FindWithTag("UI");
		uiButtons = special.GetComponent<UIButtons>();

		playerHealth.IncreaseHealth(PlayerParams.health);
		uiText.score(PlayerParams.score);
		uiButtons.SpecialUp(PlayerParams.special);
	}
}
