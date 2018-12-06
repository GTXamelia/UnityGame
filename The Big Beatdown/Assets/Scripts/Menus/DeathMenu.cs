using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
	// If main menu button is clicked
	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu"); // Load main mneu scene
	}

	// If quit button is clicked
	public void Quit()
	{
		Application.Quit(); // End application
	}
}
