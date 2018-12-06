using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
	// Private variables used in this class
	private GameObject player;
	private PlayerController playerMove;
	private GameObject[] OBCount;
	private EnemyHealth enemyHealth;
	private PlayerHealth playerHealth;

	// Public variables that can be used outside this class
	public AudioClip specialClip;
	public Text specialLabel;
	public int specialCount = 1;

	// Initialization
	void Start()
	{
		try
		{
			specialLabel.text = string.Format("X{0}", specialCount);
		}
		catch (Exception e)
		{

		}

		player = GameObject.FindGameObjectWithTag("Player");
		playerMove = player.GetComponent<PlayerController>();
		playerHealth = player.GetComponent<PlayerHealth>();
	}

	// Detects when left button is down
	public void LeftDown()
	{
		playerMove.moveLeft = true;
		playerMove.lastPos = false;
	}

	// Detects when left button is up
	public void LeftUp()
	{
		playerMove.moveLeft = false;
	}

	// Detects when right button is down
	public void RightDown()
	{
		playerMove.moveRight = true;
		playerMove.lastPos = true;
	}

	// Detects when right button is up
	public void RightUp()
	{
		playerMove.punch = false;
		playerMove.moveRight = false;
	}

	// Detects when punch button is down
	public void PunchDown()
	{
		playerMove.punch = true;
	}

	// Detects when punch button is up
	public void PunchUp()
	{
		playerMove.punch = false;
	}

	// Function used to decrement the players special ability
	public void SpecialDown()
	{
		if (specialCount > 0) // If special is greater than 0
		{
			OBCount = GameObject.FindGameObjectsWithTag("Enemies"); // Get all objects with tag 'Enemies'

			// Loop through enemies and give them 20 damge each
			for (int i = 0; i < OBCount.Length; i++)
			{
				enemyHealth = OBCount[i].GetComponent<EnemyHealth>();
				enemyHealth.TakeDamage(20);
			}

			// Play spceial ability sound ofa plane shooting
			playerHealth.ClipPlay(specialClip);

			// Decrement special count
			specialCount--;

			// Update text onscreen of new special count
			specialLabel.text = string.Format("X{0}", specialCount);
		}
	}

	// Function used to increment the players special ability
	public void SpecialUp(int amount)
	{
		specialCount += amount; // Increase abilty by 1

		specialLabel.text = string.Format("X{0}", specialCount); // Update ability on screen
	}
}
