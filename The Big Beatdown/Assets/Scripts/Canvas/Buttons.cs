using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	public bool left = false;

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
	}

	public void LeftUp()
	{
		playerMove.moveLeft = false;
	}

	public void RightDown()
	{
		playerMove.moveRight = true;
	}

	public void RightUp()
	{
		playerMove.moveRight = false;
	}

	public void Punch()
	{

	}
}
