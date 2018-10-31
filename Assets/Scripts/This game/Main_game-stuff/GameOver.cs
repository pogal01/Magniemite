using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public bool Stop;
	public bool End ;
	public bool Chance2;

	// Use this for initialization
	void Start () {
		Stop = false;
		End = false;
		Chance2 = false;
	}

	void ENDFALSE()
	{

		End = false;
	}


	// Update is called once per frame
	void Update () {

		if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().Reseting == true)
		{
			Stop = false;

		}


		// Spike 1
		if (GameObject.Find("Spike").GetComponent<Destroy_player>().GameOver == true)    
		{
		if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().Reseted == true)
		{
			Chance2 = false;
		}
		Stop = true;
		End = true;
	//	Debug.Log("Ending Game");
		Invoke("ENDFALSE", 1);
		}
		//
		if (GameObject.Find("Spike").GetComponent<Destroy_player>().GameOver == false)
		{
			if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().Reseting == true)
			{
				End = false;
		//		Debug.Log("Restarting");
			}
		}
		// Spike 2
		if (GameObject.Find("Spike2").GetComponent<Destroy_player>().GameOver == true)
		{
			if (GameObject.Find("Spike2").GetComponent<Spawn_loc1>().Reseted == true)
			{
				Chance2 = false;

			}
			Stop = true;
			End = true;
		//	Debug.Log("Ending Game");
			Invoke("ENDFALSE", 1);
		}
		//
		if (GameObject.Find("Spike2").GetComponent<Destroy_player>().GameOver == false)
		{
			if (GameObject.Find("Spike2").GetComponent<Spawn_loc1>().Reseting == true)
			{
				End = false;
		//		Debug.Log("Restarting");
			}



		}
		//Spike 3
		if (GameObject.Find("Spike3").GetComponent<Destroy_player>().GameOver == true)
		{
			if (GameObject.Find("Spike3").GetComponent<Spawn_loc1>().Reseted == true)
			{
				End = false;
			}
			Stop = true;
			End = true;
			//Debug.Log("Ending Game");
			Invoke("ENDFALSE", 1);
			//
			if (GameObject.Find("Spike3").GetComponent<Destroy_player>().GameOver == false)
			{
				if (GameObject.Find("Spike3").GetComponent<Spawn_loc1>().Reseting == true)
				{
					End = false;
			//		Debug.Log("Restarting");
				}
				

			}
		}
		//Spike 4
		if (GameObject.Find("Spike4").GetComponent<Destroy_player>().GameOver == true)
		{

			if (GameObject.Find("Spike4").GetComponent<Spawn_loc1>().Reseted == true)
			{
				Chance2 = false;
			}
			Stop = true;
			End = true;
		//	Debug.Log("Ending Game");
			Invoke("ENDFALSE", 1);
			//
			if (GameObject.Find("Spike4").GetComponent<Destroy_player>().GameOver == false)
			{
				if (GameObject.Find("Spike4").GetComponent<Spawn_loc1>().Reseting == true)
				{
					End = false;
		//			Debug.Log("Restarting");
				}
				
			}
		}
		// Spike 5
		if (GameObject.Find("Spike5").GetComponent<Destroy_player>().GameOver == true)
		{
			if (GameObject.Find("Spike5").GetComponent<Spawn_loc1>().Reseted == true)
			{
				Chance2 = false;
			}
			Stop = true;
			End = true;
		//	Debug.Log("Ending Game");
			Invoke("ENDFALSE", 2);
			//
			if (GameObject.Find("Spike5").GetComponent<Destroy_player>().GameOver == false)
			{
				if (GameObject.Find("Spike5").GetComponent<Spawn_loc1>().Reseting == true)
				{
					End = false;
		//			Debug.Log("Restarting");
				}
			
			}

		}
		//When player is revived
		//Normal
		
		//Original
		if (GameObject.Find("InvisablePufferfish2").GetComponent<Difficulty>().Normal == true)
		{
			if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 0)
			{
				if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Revived == true)
				{
				Chance2 = true;
				}
			}

		}
		//Cute
		if (GameObject.Find("InvisablePufferfish2").GetComponent<Difficulty>().Normal == true)
		{
			if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 1)
			{
				if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Revived == true)
				{
					Chance2 = true;
				}
			}

		}
		//Hard
		//Original
		if (GameObject.Find("InvisablePufferfish2").GetComponent<Difficulty>().Hard == true)
		{
			if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 0)
			{
				if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Revived == true)
				{
					Chance2 = true;
				}
			}

		}
		//Cute
		if (GameObject.Find("InvisablePufferfish2").GetComponent<Difficulty>().Hard == true)
		{
			if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 1)
			{
				if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Revived == true)
				{
					Chance2 = true;
				}
			}

		}
		//Chance2 = true;
	}
}
