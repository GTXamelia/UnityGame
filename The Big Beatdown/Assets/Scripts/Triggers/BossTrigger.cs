using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour {

	public GameObject BossCollider;

	void start()
	{
		BossCollider.SetActive(true);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		BossCollider.SetActive(false);
	}

}
