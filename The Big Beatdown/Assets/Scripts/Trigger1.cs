using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {

	bool activated;

	public GameObject enemy;
	public Transform[] spawnPoints;

	void Awake()
	{

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("Trigger1 collided with " + col.name + " " + this.activated);

		if (this.activated == false)
		{
			Debug.Log("Spawn enemies");

			int spawnPointIndex = Random.Range(0, spawnPoints.Length);

			var clone = Instantiate(enemy, spawnPoints[spawnPointIndex].position, transform.rotation);

			this.activated = true;
		}
		else
		{
			Debug.Log("Already triggered :" + this.activated);
		}

	}
}