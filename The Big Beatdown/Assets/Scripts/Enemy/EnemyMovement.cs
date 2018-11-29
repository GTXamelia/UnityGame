using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

	public float speed;
	public Transform Player;
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}
	
	void Update()
	{
		Vector3 displacement = Player.position - transform.position;
		displacement = displacement.normalized;
		if (Vector2.Distance(Player.position, transform.position) > 1.4f)
		{
			transform.position += (displacement * speed * Time.deltaTime);
		}
	}
}
