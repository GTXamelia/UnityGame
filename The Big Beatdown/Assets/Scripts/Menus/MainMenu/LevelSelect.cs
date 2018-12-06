using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	// Runs when Level1 button is clicked
	public void Level1()
	{
		SceneManager.LoadScene("Level1"); // Load Level1 scene
	}

	// Runs when Level2 button is clicked
	public void Level2()
	{
		SceneManager.LoadScene("Level2"); // Load Level2 scene
	}

	// Runs when Level3 button is clicked
	public void Level3()
	{
		SceneManager.LoadScene("Level3"); // Load Level3 scene
	}
}
