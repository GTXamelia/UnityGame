using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour {

	public GameObject Boss;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (!Boss.active)
		{
			SceneManager.LoadScene("MainMenu");
		}
		
	}
}
