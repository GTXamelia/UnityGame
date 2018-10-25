﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

	public GameObject settings;

	// Use this for initialization
	void Awake()
	{
		Debug.Log("Awake");

		settings = GameObject.Find("SettingsBubble");

		settings.SetActive(false);
	}

	public void SettingsMenu()
	{
		if (settings.active)
		{
			settings.SetActive(false);
		}
		else
		{
			settings.SetActive(true);
		}
	}
}
