using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

	public float speed;
	public Transform Player;

	void Start()
	{
	}
	
	void Update()
	{
		Vector3 displacement = Player.position - transform.position;
		displacement = displacement.normalized;
		if (Vector2.Distance(Player.position, transform.position) > 1.4f)
		{
			transform.position += (displacement * speed * Time.deltaTime);

			if(displacement.x > 0)
			{
				GetComponent<Animator>().Play("Player_Right");
			}
			else
			{
				GetComponent<Animator>().Play("Player_Left");
			}
		}
		else
		{
			Debug.Log(displacement.x);

			if (displacement.x > 0)
			{
				GetComponent<Animator>().Play("Punch_Right");
			}
			else
			{
				GetComponent<Animator>().Play("Punch_Left");
			}
		}	
	}
}
