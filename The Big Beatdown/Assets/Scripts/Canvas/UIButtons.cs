using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
	private GameObject player;
	private PlayerController playerMove;
	private GameObject[] OBCount;
	private EnemyHealth enemyHealth;
	private PlayerHealth playerHealth;

	public AudioClip specialClip;
	public Text specialLabel;
	public int specialCount = 1;

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

	public void LeftDown()
	{
		playerMove.moveLeft = true;
		playerMove.lastPos = false;
	}

	public void LeftUp()
	{
		playerMove.moveLeft = false;
	}

	public void RightDown()
	{
		playerMove.moveRight = true;
		playerMove.lastPos = true;
	}

	public void RightUp()
	{
		playerMove.punch = false;
		playerMove.moveRight = false;
	}

	public void PunchDown()
	{
		playerMove.punch = true;
	}

	public void PunchUp()
	{
		playerMove.punch = false;
	}

	public void SpecialDown()
	{
		if (specialCount > 0)
		{
			OBCount = GameObject.FindGameObjectsWithTag("Enemies");

			for (int i = 0; i < OBCount.Length; i++)
			{
				enemyHealth = OBCount[i].GetComponent<EnemyHealth>();
				enemyHealth.TakeDamage(10);
			}

			playerHealth.ClipPlay(specialClip);

			specialCount--;

			specialLabel.text = string.Format("X{0}", specialCount);

			PlayerParams.special = specialCount;
		}
	}
}
