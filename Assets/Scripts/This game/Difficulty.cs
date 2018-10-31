using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Difficulty : MonoBehaviour {

	
	public bool Normal = false;
	public bool Hard = false;

	void Start()
	{
	
	 Normal= false;
	 Hard =false;
	}


	
	public void NormalDifficulty()
	{
		Debug.Log("NormalDifficulty Has been selected");
		SceneManager.LoadScene("Main");
		Normal = true;
	}

	public void HardDifficulty()
	{
		Debug.Log("HardDifficulty Has been selected");
		SceneManager.LoadScene("Hard");
		Hard = true;
	}
	public void Back()
	{
		Debug.Log("Back");
		SceneManager.LoadScene("Start");
		Normal = false;
		Hard = false;
	}

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		Debug.Log("Awake:" + this.gameObject);

	}

	public void Update()
	{
		if (GameObject.Find("InvisablePufferfish6").GetComponent<WhichSceneIsthis>().Scene == 4)
		{
			if (GameObject.Find("Difficulty").GetComponent<Difficulty2>().Normal == true)
			{
				NormalDifficulty();
			}
			if (GameObject.Find("Difficulty").GetComponent<Difficulty2>().Hard == true)
			{
				HardDifficulty();
			}
			if (GameObject.Find("Difficulty").GetComponent<Difficulty2>().BackB == true)
			{
				Back();
			}

		}
		
	}

	

}
