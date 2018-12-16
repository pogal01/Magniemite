using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public bool Stop;
	public bool End ;
	public bool Chance2;


	private GameObject Spike1;
	private GameObject Spike2;
	private GameObject Spike3;
	private GameObject Spike4;
	private GameObject Spike5;
	private GameObject InvisPuffer2;
	private GameObject InvisPuffer3;
	private GameObject InvisPuffer5;

	private void Awake()
	{
		Spike1 = GameObject.Find("Spike");
		Spike2 = GameObject.Find("Spike2");
		Spike3 = GameObject.Find("Spike3");
		Spike4 = GameObject.Find("Spike4");
		Spike5 = GameObject.Find("Spike5");
		InvisPuffer2 = GameObject.Find("InvisablePufferfish2");
		InvisPuffer3 = GameObject.Find("InvisablePufferfish3");
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}

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

		if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
		{
			Stop = false;

		}


		// Spike 1
		if (Spike1.GetComponent<Destroy_player>().GameOver == true)    
		{
		if (Spike1.GetComponent<Spawn_loc1>().Reseted == true)
		{
			Chance2 = false;
		}
		Stop = true;
		End = true;
	//	Debug.Log("Ending Game");
		Invoke("ENDFALSE", 1);
		}
		//
		if (Spike1.GetComponent<Destroy_player>().GameOver == false)
		{
			if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
			{
				End = false;
		//		Debug.Log("Restarting");
			}
		}
		// Spike 2
		if (Spike2.GetComponent<Destroy_player>().GameOver == true)
		{
			if (Spike2.GetComponent<Spawn_loc1>().Reseted == true)
			{
				Chance2 = false;

			}
			Stop = true;
			End = true;
		//	Debug.Log("Ending Game");
			Invoke("ENDFALSE", 1);
		}
		//
		if (Spike2.GetComponent<Destroy_player>().GameOver == false)
		{
			if (Spike2.GetComponent<Spawn_loc1>().Reseting == true)
			{
				End = false;
		//		Debug.Log("Restarting");
			}



		}
		//Spike 3
		if (Spike3.GetComponent<Destroy_player>().GameOver == true)
		{
			if (Spike3.GetComponent<Spawn_loc1>().Reseted == true)
			{
				End = false;
			}
			Stop = true;
			End = true;
			//Debug.Log("Ending Game");
			Invoke("ENDFALSE", 1);
			//
			if (Spike3.GetComponent<Destroy_player>().GameOver == false)
			{
				if (Spike3.GetComponent<Spawn_loc1>().Reseting == true)
				{
					End = false;
			//		Debug.Log("Restarting");
				}
				

			}
		}
		//Spike 4
		if (Spike4.GetComponent<Destroy_player>().GameOver == true)
		{

			if (Spike4.GetComponent<Spawn_loc1>().Reseted == true)
			{
				Chance2 = false;
			}
			Stop = true;
			End = true;
		//	Debug.Log("Ending Game");
			Invoke("ENDFALSE", 1);
			//
			if (Spike4.GetComponent<Destroy_player>().GameOver == false)
			{
				if (Spike4.GetComponent<Spawn_loc1>().Reseting == true)
				{
					End = false;
		//			Debug.Log("Restarting");
				}
				
			}
		}
		// Spike 5
		if (Spike5.GetComponent<Destroy_player>().GameOver == true)
		{
			if (Spike5.GetComponent<Spawn_loc1>().Reseted == true)
			{
				Chance2 = false;
			}
			Stop = true;
			End = true;
		//	Debug.Log("Ending Game");
			Invoke("ENDFALSE", 2);
			//
			if (Spike5.GetComponent<Destroy_player>().GameOver == false)
			{
				if (Spike5.GetComponent<Spawn_loc1>().Reseting == true)
				{
					End = false;
		//			Debug.Log("Restarting");
				}
			
			}

		}
		//When player is revived
		//Normal
		
		//Original
		if (InvisPuffer2.GetComponent<Difficulty>().Normal == true)
		{
			if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 0)
			{
				if (InvisPuffer5.GetComponent<Player_Start>().Revived == true)
				{
				Chance2 = true;
				}
			}

		}
		//Cute
		if (InvisPuffer2.GetComponent<Difficulty>().Normal == true)
		{
			if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 1)
			{
				if (InvisPuffer5.GetComponent<Player_Start>().Revived == true)
				{
					Chance2 = true;
				}
			}

		}
		//Hard
		//Original
		if (InvisPuffer2.GetComponent<Difficulty>().Hard == true)
		{
			if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 0)
			{
				if (InvisPuffer5.GetComponent<Player_Start>().Revived == true)
				{
					Chance2 = true;
				}
			}

		}
		//Cute
		if (InvisPuffer2.GetComponent<Difficulty>().Hard == true)
		{
			if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 1)
			{
				if (InvisPuffer5.GetComponent<Player_Start>().Revived == true)
				{
					Chance2 = true;
				}
			}

		}
		//Chance2 = true;
	}
}
