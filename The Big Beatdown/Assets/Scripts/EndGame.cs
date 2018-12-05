using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	public GameObject Player;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			PlayerParams.health = 5;
			SceneManager.LoadScene("Level2"); ;
		}
	}
}
