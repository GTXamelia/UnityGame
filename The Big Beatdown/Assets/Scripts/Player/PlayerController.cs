using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	// Private variables
	private AudioSource playerAudio;
	private Animator anim;

	// Public variables
	public float speed;
	public bool moveRight = false;
	public bool moveLeft = false;
	public bool punch = false;
	public bool lastPos = true;
	public AudioClip hitClip;
	public GameObject triggerLeft;
	public GameObject triggerRight;

	// Ran once
	void Awake()
	{
		triggerLeft = GameObject.Find("LeftPlayerCollider"); // find LeftPlayerCollider object
		triggerRight = GameObject.Find("RightPlayerCollider"); // RightPlayerCollider object

		triggerLeft.SetActive(false); // Set object to inactive
		triggerRight.SetActive(false); // Set object to inactive
	}

	// Ran once
	void Start () {
		anim = GetComponent<Animator>();// Get Animator component

		playerAudio = GetComponent<AudioSource>(); // Get AudioSource component
	}
	
	// Ran each frame
	void Update()
	{
		Movement(); // Run movement function
		{
			float move = Input.GetAxis("Horizontal"); // Set move to Horizontal only
			anim.SetFloat("speed", move); // Set speed function in animator
		}
	}

	void Movement()
	{
		if ((Input.GetKey(KeyCode.Z) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))) || punch == true && lastPos == true) // If player is trying to punch right
		{
			GetComponent<Animator>().Play("Punch_Right"); // Play punch right animation
			playerAudio.clip = hitClip;  // Setup punch clip
			playerAudio.Play(); // Play punch clip
			triggerRight.SetActive(true); // Set right collider to true
		}
		else if ((Input.GetKey(KeyCode.Z) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))) || punch == true && lastPos == false) // If player is trying to punch left
		{
			GetComponent<Animator>().Play("Punch_Left"); // Play punch left animation
			playerAudio.clip = hitClip; // Setup punch clip
			playerAudio.Play(); // Play punch clip
			triggerLeft.SetActive(true); // Set right collider to left
		}
		else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || moveRight) // If player is trying to move right
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime); // Move object
			transform.eulerAngles = new Vector2(0, 0); // Move on 2d plane

			GetComponent<Animator>().Play("Player_Right"); // Play right movement animation

			// Set triggers to inactive
			triggerLeft.SetActive(false); 
			triggerRight.SetActive(false);
		}
		else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || moveLeft) // If player is trying to move right
		{
			transform.Translate(-Vector2.right * speed * Time.deltaTime); // Move object
			transform.eulerAngles = new Vector2(0, 0); // Move on 2d plane

			GetComponent<Animator>().Play("Player_Left"); // Play left movement animation

			// Set triggers to inactive
			triggerLeft.SetActive(false);
			triggerRight.SetActive(false);
		}
		else
		{
			GetComponent<Animator>().Play("Idle"); // Play idle animation

			// Set triggers to inactive
			triggerLeft.SetActive(false);
			triggerRight.SetActive(false);
		}
	}
}
