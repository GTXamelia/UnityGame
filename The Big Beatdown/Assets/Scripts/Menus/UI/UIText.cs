using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour {

	public Text timerLabel;
	public Text scoreLabel;

	private float time;
	private int scoreAmount = 0;

	void Start()
	{
		scoreLabel.text = string.Format("Score:{0}", scoreAmount);
	}

	void Update()
	{
		time += Time.deltaTime;

		float minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
		float seconds = time % 60; //Use the euclidean division for the seconds.
		float fraction = (time * 100) % 100;

		//update the label value
		timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
	}

	public void score(int amount)
	{
		scoreAmount += amount;

		scoreLabel.text = string.Format("Score:{0}", scoreAmount);
	}
}
