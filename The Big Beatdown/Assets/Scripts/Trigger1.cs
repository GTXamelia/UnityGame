using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{

	bool activated;

	public GameObject enemy;
	public Transform[] spawnPoints;

	private GameObject clone;
	private GameObject[] OBCount;

	public GameObject ColliderLeft;
	public GameObject ColliderRight;

	void Awake()
	{
		OBCount = GameObject.FindGameObjectsWithTag("Enemies");
	}

	void Update()
	{
		OBCount = GameObject.FindGameObjectsWithTag("Enemies");
		Debug.Log(OBCount.Length);
		if(OBCount.Length <= 0)
		{
			ColliderLeft.SetActive(false);
			ColliderRight.SetActive(false);
			Debug.Log("Inactive");
		}
		else
		{
			ColliderLeft.SetActive(true);
			ColliderRight.SetActive(true);
			Debug.Log("Active");
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{

		if (this.activated == false)
		{
			StartCoroutine(SpawnAsync());

			this.activated = true;
		}
	}

	IEnumerator SpawnAsync()
	{
		for (int i = 0; i < 5; i++)
		{
			clone = Instantiate(enemy, spawnPoints[0].position, transform.rotation);
			clone.tag = "Enemies";
			clone = Instantiate(enemy, spawnPoints[1].position, transform.rotation);
			clone.tag = "Enemies";

			yield return new WaitForSeconds(5.0f);
		}
	}
}