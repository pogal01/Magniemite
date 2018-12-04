using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
	

	public void PlayGame()
	{
		SceneManager.LoadScene("Difficulty_Screen");

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
