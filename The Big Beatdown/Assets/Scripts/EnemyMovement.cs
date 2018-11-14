using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

	public float speed;
	public Transform Player;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector3 displacement = Player.position - transform.position;
		displacement = displacement.normalized;
		if (Vector2.Distance(Player.position, transform.position) > 2.0f)
		{
			transform.position += (displacement * speed * Time.deltaTime);

		}
		else
		{
			//call hit player method
		}

	}

}
