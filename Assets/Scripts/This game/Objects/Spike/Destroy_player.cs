using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_player : MonoBehaviour
{
	public bool GameOver;

	private GameObject InvisPuffer3;
	private GameObject Magniemite;
	private GameObject Cute;
	private GameObject Dragnie;
	private GameObject Magnieling;
	private GameObject Spike1;
	private GameObject Spike2;
	private GameObject Spike3;
	private GameObject Spike4;
	private GameObject Spike5;




	private void Awake()
	{
		InvisPuffer3 = GameObject.Find("InvisablePufferfish3");
		Magniemite = GameObject.Find("Magneimite");
		Cute = GameObject.Find("Cute");
		Dragnie = GameObject.Find("Dragniemite");
		Magnieling = GameObject.Find("Magnieling");
		Spike1 = GameObject.Find("Spike");
		Spike2 = GameObject.Find("Spike2");
		Spike3 = GameObject.Find("Spike3");
		Spike4 = GameObject.Find("Spike4");
		Spike5 = GameObject.Find("Spike5");
	}


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
		
		if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 0)
		{
			if (Magniemite.GetComponent<Damaged>().Hit == true)
			{
				PlayerHit();
			}
		}

		
			//Cute
		
		if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 1)
		{
			if (Cute.GetComponent<Damaged>().Hit == true)
			{
				PlayerHit();
			}
		}

			//Dragonmite
		if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 2)
		{
			if (Dragnie.GetComponent<Damaged>().Hit == true)
			{
					PlayerHit();
			}
		}

		//Magnieling
		if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 3)
		{
			if (Magnieling.GetComponent<Damaged>().Hit == true)
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
		if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (Spike2.GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (Spike3.GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (Spike4.GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		if (Spike5.GetComponent<Spawn_loc1>().Reseting == true)
		{
			GameOver = false;
		}
		CheckForHit();
	}
	


}
  