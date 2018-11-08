using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Level1()
	{
		SceneManager.LoadScene("Level1");
	}

	public void Level2()
	{
		SceneManager.LoadScene("Level2");
	}

	public void Level3()
	{
		SceneManager.LoadScene("Level3");
	}
}
