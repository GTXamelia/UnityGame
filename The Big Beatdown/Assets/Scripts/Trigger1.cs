using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {

	void Awake()
	{
		BoxCollider2D bc;
		bc = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
		bc.size = new Vector2(3.0f, 1.0f);
		bc.isTrigger = true;

		gameObject.transform.localScale = new Vector3(3.0f, 1.0f, 1.0f);
		gameObject.transform.position = new Vector3(0.0f, -2.0f, 0.0f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("GameObject2 collided with " + col.name);
	}
}
