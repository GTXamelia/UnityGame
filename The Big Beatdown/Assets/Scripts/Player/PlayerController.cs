using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private AudioSource playerAudio;
	private Animator anim;

	public float speed;
	public bool moveRight = false;
	public bool moveLeft = false;
	public bool punch = false;
	public bool lastPos = true;
	public AudioClip hitClip;
	public GameObject triggerLeft;
	public GameObject triggerRight;

	void Awake()
	{
		triggerLeft = GameObject.Find("LeftPlayerCollider");
		triggerRight = GameObject.Find("RightPlayerCollider");

		triggerLeft.SetActive(false);
		triggerRight.SetActive(false);
	}

	void Start () {
		anim = GetComponent<Animator>();

		playerAudio = GetComponent<AudioSource>();
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
		if ((Input.GetKey(KeyCode.Z) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))) || punch == true && lastPos == true)
		{
			GetComponent<Animator>().Play("Punch_Right");
			playerAudio.clip = hitClip;
			playerAudio.Play();
			triggerRight.SetActive(true);
		}
		else if ((Input.GetKey(KeyCode.Z) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))) || punch == true && lastPos == false)
		{
			GetComponent<Animator>().Play("Punch_Left");
			playerAudio.clip = hitClip;
			playerAudio.Play();
			triggerLeft.SetActive(true);
		}
		else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || moveRight)
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);

			GetComponent<Animator>().Play("Player_Right");

			triggerLeft.SetActive(false);
			triggerRight.SetActive(false);
		}
		else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || moveLeft)
		{
			transform.Translate(-Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);

			GetComponent<Animator>().Play("Player_Left");

			triggerLeft.SetActive(false);
			triggerRight.SetActive(false);
		}
		else
		{
			GetComponent<Animator>().Play("Idle");

			triggerLeft.SetActive(false);
			triggerRight.SetActive(false);
		}
	}
}
