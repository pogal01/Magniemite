using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSkin : MonoBehaviour {
	public bool Normal;
	public bool Halloween;   // Add other events here
	public bool Christmas;
	public GameObject Spike;
	public GameObject Pumpkin;
	public GameObject SnowFlake;





	// Use this for initialization
	void Start ()
	{

		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == false)
		{
			Normal = true;
			DisableOtherSkins();

		}
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			Normal = true;
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Halloween == true)
			{

				Normal = false;
				Halloween = true;
				Christmas = false;

			}
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Christmas == true)
			{

				Normal = false;
				Halloween = false;
				Christmas = true;

			}
		}




	}

	// Update is called once per frame
	void FixedUpdate () {
		if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().SpriteActivation == true)
		{ 
			if (Halloween == true)
			{
			Pumpkin.gameObject.SetActive(true);
			Spike.gameObject.SetActive(false);
			SnowFlake.gameObject.SetActive(false);
			}

			if (Normal == true)
			{
			Pumpkin.gameObject.SetActive(false);
			Spike.gameObject.SetActive(true);
			SnowFlake.gameObject.SetActive(false);
			}

			if (Christmas == true)
			{
				Pumpkin.gameObject.SetActive(false);
				Spike.gameObject.SetActive(false);
				SnowFlake.gameObject.SetActive(true);
			}
		}
		else
		{
			Pumpkin.gameObject.SetActive(false);
			Spike.gameObject.SetActive(true);
			SnowFlake.gameObject.SetActive(false);
		}
	}

	void DisableOtherSkins() // Put the other events bool here
	{
		Halloween = false;
		Christmas = false;
	}



}
