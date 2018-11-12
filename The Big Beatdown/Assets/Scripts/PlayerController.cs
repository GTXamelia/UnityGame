using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update()
	{

		Movement();
		{
			float move = Input.GetAxis("Horizontal");
			anim.SetFloat("speed", move);
		}

	}

	void Movement()
	{
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);

			GetComponent<Animator>().Play("Player_Right");
		}
		else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);

			GetComponent<Animator>().Play("Player_Left");
		}
		else
		{
			GetComponent<Animator>().Play("Idle");
		}
	}
}
