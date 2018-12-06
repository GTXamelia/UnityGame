using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsButton : MonoBehaviour
{
	// Public variable
	public GameObject menu;

	// Ran once
	void Awake()
	{
		menu = GameObject.Find("LevelsBubble"); // Find LevelsBubble object

		menu.SetActive(false); // Set pop-out to false
	}

	// Runs when levels button is clicked
	public void LevelsMenu()
	{
		if (menu.active) // If pop-out is active
		{
			menu.SetActive(false); // Change to inactive
		}
		else // Else pop-out is inactive 
		{
			menu.SetActive(true); // Change pop-out to active
		}
	}
}
