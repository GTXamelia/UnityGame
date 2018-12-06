using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	// Public varibles
	public float speed;
	public Transform Player;
	
	// Run every frame
	void Update()
	{
		Vector3 displacement = Player.position - transform.position; // Get player position in relation to object
		displacement = displacement.normalized;

		// If player is a certain distance away
		if (Vector2.Distance(Player.position, transform.position) > 1.4f)
		{
			transform.position += (displacement * speed * Time.deltaTime); // Move towards player

			if(displacement.x > 0) // If x is greater than 0 than player is to the right of object
			{
				GetComponent<Animator>().Play("Player_Right"); // Play run right animation
			}
			else // Else player is left
			{
				GetComponent<Animator>().Play("Player_Left"); // Play run right animation
			}
		}
		else // If player is within a certain distance
		{
			if (displacement.x > 0) // If x is greater than 0 than player is to the right of object
			{
				GetComponent<Animator>().Play("Punch_Right"); // Punch right animation
			}
			else // Else player is left
			{
				GetComponent<Animator>().Play("Punch_Left"); // Punch left animation
			}
		}	
	}
}
