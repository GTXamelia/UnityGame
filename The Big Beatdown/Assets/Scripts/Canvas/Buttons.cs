using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	GameObject player;
	PlayerController playerMove;
	private GameObject[] OBCount;
	EnemyHealth enemyHealth;
	public AudioClip eatClip;
	PlayerHealth playerHealth;

	public int specialCount = 0;

	void Start()
	{
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
		OBCount = GameObject.FindGameObjectsWithTag("Enemies");

		for (int i = 0; i < OBCount.Length; i++)
		{
			enemyHealth = OBCount[i].GetComponent<EnemyHealth>();
			enemyHealth.TakeDamage(10);
		}

		playerHealth.ClipPlay(eatClip);
	}
}
