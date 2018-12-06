using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
	// Timer variable used to display the time
	private float time;

	// On screen text 
	public Text timerLabel;
	public Text scoreLabel;
	public int scoreAmount = 0;

	// Initialization
	void Start()
	{
		scoreLabel.text = string.Format("Score:{0}", scoreAmount); // Set score to initial setting '0'
	}

	// Run each frame
	void Update()
	{
		time += Time.deltaTime; // Get time

		float minutes = time / 60; // Divide the guiTime by sixty to get the minutes.
		float seconds = time % 60; // Use the euclidean division for the seconds.
		float fraction = (time * 100) % 100; // Fraction of a second

		//update the text value
		timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
	}

	// Function used to update score of the player
	public void score(int amount)
	{
		scoreAmount += amount; // Increment score by itself and number

		scoreLabel.text = string.Format("Score:{0}", scoreAmount); // Update text on screen with new score
	}
}
