using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private bool moving;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate()
	{

		if (Input.GetKey("left") || Input.GetKey("right"))
		{

			moving = true;

		}
		else { moving = false; }

		if (moving)
		{
			float moveHotizontal = Input.GetAxisRaw("Horizontal");
			float moveVertical = Input.GetAxisRaw("Vertical");

			Vector2 movement = new Vector2(moveHotizontal, moveVertical);

			rb2d.AddForce(movement * speed);
		} else { rb2d.velocity = Vector2.zero; }
	}
}
