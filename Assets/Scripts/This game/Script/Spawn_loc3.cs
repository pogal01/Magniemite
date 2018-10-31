using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_loc3 : MonoBehaviour
{

	GameObject[] SpikeSpawnPos;
	GameObject Currentposition;
	public GameObject Thing;
	public string Tag;
	int index;
	public bool Spike3Destroyed;
	public bool Reseting = false;
	public bool Reseted = false;
	public bool Script = true;


	// Use this for initialization
	void Start()
	{

		SpikeSpawn();
		Spike3Destroyed = false;
		Reseting = false;
		Reseted = false;
		Script = true;

	}

	void SpikeSpawn()
	{
		SpikeSpawnPos = GameObject.FindGameObjectsWithTag(Tag);
		index = Random.Range(0, SpikeSpawnPos.Length);
		Currentposition = SpikeSpawnPos[index];
		//print(Currentposition.name); <--(Unused now)
		Thing.transform.position = Currentposition.transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (Script == true)
		{
			if (other.tag == "Destroy")
			{
				if (GameObject.Find("Spike3").GetComponent<Destroy_player>().GameOver == false)
				{
					SpikeSpawn();
					//Debug.Log("Spike 3 Respawned");


				}
			}
		}
	}

	void Restart()
	{

		if (Reseting == true)
		{

			SpikeSpawn();
			Spike3Destroyed = false;
			Script = true;
			gameObject.GetComponent<SpriteRenderer>().enabled = true;
			//Debug.Log("Spike 3 Reset");
			Reseted = true;
			if (Reseted == true)
			{
				Reseting = false;
			}

		}

	}

	public void ResetSpikes()
	{
		if (Reseted == false)
		{
			SpikeSpawn();
			Reseting = true;
			//Debug.Log("Recreated spike 3");
			Spike3Destroyed = false;

			if (Reseting == true)
			{
				Invoke("Restart", 1);
			}
		}
	}

	void Update()
	{
		if (GameObject.Find("EndWall").GetComponent<GameOver>().End == true)
		{
			SpikeSpawn();
			//Debug.Log("Destroyed spike 3");
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
			Spike3Destroyed = true;

		}

		//Normal

		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Revived == true)
		{
			ResetSpikes();
		}

	}


}
