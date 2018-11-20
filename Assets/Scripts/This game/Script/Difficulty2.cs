using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Difficulty2 : MonoBehaviour
{
	// This is on the difficultys script not invis puffer

	public bool Normal = false;
	public bool Hard = false;
	public bool BackB = false;

	void Start()
	{

		Normal = false;
		Hard = false;
		BackB = false;
	}



	public void Backagain()
		{
			if(BackB == true)
			{
			BackB = false;
			}
		}

	public void NormalDifficulty()
	{
		Debug.Log("NormalDifficulty Has been selected on Difficulty2");
		Hard = false;
		Normal = true;
		
	}

	public void HardDifficulty()
	{
		Debug.Log("HardDifficulty Has been selected on Difficulty2");
		Normal = false;
		Hard = true;
	}
	public void Back()
	{
		Debug.Log("Back");
		BackB = true;
		Normal = false;
		Hard = false;
		Invoke("Backagain", 1);
	}


	/*

	ReviveScreen = false;
	ADError = false;
	Skiped = false;
	*/

}
