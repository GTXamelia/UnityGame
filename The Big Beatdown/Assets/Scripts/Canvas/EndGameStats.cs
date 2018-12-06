using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameStats : MonoBehaviour
{
	// Text objects on screen
	public Text scoreLabel;
	public Text healthLabel;
	public Text spcecialLabel;

	// Initialization
	void Start ()
	{
		scoreLabel.text = string.Format("Score:{0}", PlayerParams.score); // Gets score from static class PlayerParams and ouputs to screen
		healthLabel.text = string.Format("Health:{0}", PlayerParams.health); // Gets health from static class PlayerParams and ouputs to screen
		spcecialLabel.text = string.Format("Special:{0}", PlayerParams.special); // Gets special from static class PlayerParams and ouputs to screen 
	}
}
