using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsButton : MonoBehaviour
{
	public GameObject menu;

	void Awake()
	{
		menu = GameObject.Find("LevelsBubble");

		menu.SetActive(false);
	}

	public void LevelsMenu()
	{
		if (menu.active)
		{
			menu.SetActive(false);
		}
		else
		{
			menu.SetActive(true);
		}
	}
}
