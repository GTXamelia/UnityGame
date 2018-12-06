using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	private GameObject player;
	private PlayerHealth playerHealth;

	private GameObject score;
	private UIText uiText;

	private GameObject special;
	private UIButtons uiButtons;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			player = GameObject.FindGameObjectWithTag("Player");
			playerHealth = player.GetComponent<PlayerHealth>();

			score = GameObject.Find("Text");
			uiText = score.GetComponent<UIText>();

			special = GameObject.FindWithTag("UI");
			uiButtons = special.GetComponent<UIButtons>();

			PlayerParams.health = playerHealth.currentHealth;
			PlayerParams.score = uiText.scoreAmount;
			PlayerParams.special = uiButtons.specialCount;

			Scene scene = SceneManager.GetActiveScene();

			if (scene.name == "Level1")
			{
				SceneManager.LoadScene("Level2");
			}
			else if (scene.name == "Level2")
			{
				SceneManager.LoadScene("Level3");
			}
			else
			{
				SceneManager.LoadScene("Done");
			}
		}
	}
}
