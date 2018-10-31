﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
	

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Quit Game");
	}

	public void InsaneMode()
	{
		Debug.Log("Insanemode activated");


	}

	


	
}
