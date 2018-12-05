using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	GameObject player;
	PlayerController playerMove;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerMove = player.GetComponent<PlayerController>();
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
		Debug.Log("Test 1");
	}

	public void SpecialUp()
	{
		Debug.Log("Test 2");
	}
}
