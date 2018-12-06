using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameStats : MonoBehaviour
{
	public Text scoreLabel;
	public Text healthLabel;
	public Text spcecialLabel;

	// Use this for initialization
	void Start ()
	{
		scoreLabel.text = string.Format("Score:{0}", PlayerParams.score);
		healthLabel.text = string.Format("Health:{0}", PlayerParams.health);
		spcecialLabel.text = string.Format("Special:{0}", PlayerParams.special);
	}
}
