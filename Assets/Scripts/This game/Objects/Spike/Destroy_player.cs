using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_player : MonoBehaviour
{
	public bool GameOver;

	void Start()
	{
		GameOver = false;
	}
	// Find out why Gameover is activated after restart

	void DisableGameover()
	{
		GameOver = false;

	}

	void CheckForHit()
	{
		
		//Original
		
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 0)
		{
			if (GameObject.Find("Magneimite").GetComponent<Damaged>().Hit == true)
			{
				PlayerHit();
			}
		}

		
			//Cute
		
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 1)
		{
			if (GameObject.Find("Cute").GetComponent<Damaged>().Hit == true)
			{
				PlayerHit();
			}
		}

			//Dragonmite
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 2)
		{
			if (GameObject.Find("Dragniemite").GetComponent<Damaged>().Hit == true)
			{
					PlayerHit();
			}
		}

		//Magnieling
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 3)
		{
			if (GameObject.Find("Magnieling").GetComponent<Damaged>().Hit == true)
			{
				PlayerHit();		
			}
		}

	}

	public void PlayerHit()
	{
		
		GameOver = true;
		//Debug.Log("hit");
	//	Debug.Log("GameOver");
		Invoke("DisableGameover", 1);
		
	}
	
	void Update()
	{
		if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (GameObject.Find("Spike2").GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (GameObject.Find("Spike3").GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (GameObject.Find("Spike4").GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (GameObject.Find("Spike5").GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		CheckForHit();
	}
	


}
  