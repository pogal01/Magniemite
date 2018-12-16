using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_loc1 : MonoBehaviour
{

	GameObject[] SpikeSpawnPos;
	GameObject Currentposition;
	public GameObject Thing;
	public string Tag;
	int index;
	public bool SpriteActivation;
	public bool loc1 = false;
	public bool loc2 = false;
	public bool loc3 = false;
	public bool loc4 = false;
	public bool loc5 = false;
	public bool SpikeDestroyed;
	public bool Reseting = false;
	public bool Reseted = false;
	public bool Script = true;

	private GameObject Endwall;
	private GameObject InvisPuffer5;


	private void Awake()
	{
		Endwall = GameObject.Find("EndWall");
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}

	// Use this for initialization
	void Start()
	{

		SpikeSpawn();
		SpikeDestroyed = false;
		Reseting = false;
		Reseted = false;
		Script = true;
		SpriteActivation = true;
}

	void SpikeSpawn()
	{
		SpikeSpawnPos = GameObject.FindGameObjectsWithTag(Tag);
		index = Random.Range(0, SpikeSpawnPos.Length);
		Currentposition = SpikeSpawnPos[index];
		//FindObjectOfType<AudioMannager>().Play("HighestSpikepass");
			if (Currentposition.name == "Loc_1")
			{
				loc1 = true;
				loc2 = false;
				loc3 = false;
				loc4 = false;
				loc5 = false;
			}
			else if (Currentposition.name == "Loc_2")
			{
				loc1 = false;
				loc2 = true;
				loc3 = false;
				loc4 = false;
				loc5 = false;

			}
			else if (Currentposition.name == "Loc_3")
			{
				loc1 = false;
				loc2 = false;
				loc3 = true;
				loc4 = false;
				loc5 = false;


			}
			else if (Currentposition.name == "Loc_4")
			{
				loc1 = false;
				loc2 = false;
				loc3 = false;
				loc4 = true;
				loc5 = false;

			}
			else if (Currentposition.name == "Loc_5")
			{
				loc1 = false;
				loc2 = false;
				loc3 = false;
				loc4 = false;
				loc5 = true;

			}

		//print(Currentposition.name);
		Thing.transform.position = Currentposition.transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (Script == true)
		{
			if (other.tag == "Destroy")
			{
				if ((Thing).GetComponent<Destroy_player>().GameOver == false)
				{
					SpikeSpawn();
					//Debug.Log("Spike 1 Respawned");


				}
			}
		}
	}

	void Restart()
	{

		if (Reseting == true)
		{

			SpikeSpawn();
			SpikeDestroyed = false;
			Script = true;
			SpriteActivation = true;
			//Debug.Log("Spike 1 Reset");
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
			//Debug.Log("Recreated spike 1");
			SpikeDestroyed = false;

			if (Reseting == true)
			{
				Invoke("Restart", 1);
			}
		}
	}

	void Update()
	{
		if (Endwall.GetComponent<GameOver>().End == true)
		{
			SpikeSpawn();
			//Debug.Log("Destroyed spike 1");
			SpriteActivation = false;
			SpikeDestroyed = true;

		}
		//Normal

		if (InvisPuffer5.GetComponent<Player_Start>().Revived == true)
		{
			ResetSpikes();
		}
	}
	


}
