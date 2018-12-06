using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
	void Start ()
	{
		Debug.Log("Level2: Health (" + PlayerParams.health + ")");
		Debug.Log("Level2: Score (" + PlayerParams.score + ")");
		Debug.Log("Level2: Special (" + PlayerParams.special + ")");
	}
}
