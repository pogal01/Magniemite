using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSkin : MonoBehaviour {
	public bool Normal;
	public bool Halloween;   // Add other events here
	public bool Christmas;
	public bool Easter;
	public GameObject Spike;
	public GameObject Pumpkin;
	public GameObject SnowFlake;
	public GameObject Easteregg;

	private GameObject EventPuffer;
	private GameObject Spike1;

	private void Awake()
	{
		EventPuffer = GameObject.Find("EventPuffer");
		Spike1 = GameObject.Find("Spike");


	}

	// Use this for initialization
	void Start ()
	{

		if (EventPuffer.GetComponent<Events>().BEvents == false)
		{
			Normal = true;
			DisableOtherSkins();

		}
		if (EventPuffer.GetComponent<Events>().BEvents == true)
		{
			Normal = true;
			if (EventPuffer.GetComponent<Events>().Halloween == true)
			{

				Normal = false;
				Halloween = true;
				Christmas = false;
				Easter = false;

			}
			if (EventPuffer.GetComponent<Events>().Christmas == true)
			{

				Normal = false;
				Halloween = false;
				Christmas = true;
				Easter = false;

			}
			if (EventPuffer.GetComponent<Events>().Easter == true)
			{

				Normal = false;
				Halloween = false;
				Christmas = false;
				Easter = true;

			}
		}




	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Spike1.GetComponent<Spawn_loc1>().SpriteActivation == true)
		{ 
			if (Halloween == true)
			{
				Pumpkin.gameObject.SetActive(true);
				Spike.gameObject.SetActive(false);
				SnowFlake.gameObject.SetActive(false);
				Easteregg.gameObject.SetActive(false);
			}

			if (Normal == true)
			{
				Pumpkin.gameObject.SetActive(false);
				Spike.gameObject.SetActive(true);
				SnowFlake.gameObject.SetActive(false);
				Easteregg.gameObject.SetActive(false);
			}

			if (Christmas == true)
			{
				Pumpkin.gameObject.SetActive(false);
				Spike.gameObject.SetActive(false);
				SnowFlake.gameObject.SetActive(true);
				Easteregg.gameObject.SetActive(false);
			}
			
			if(Easter == true)
			{
				Pumpkin.gameObject.SetActive(false);
				Spike.gameObject.SetActive(false);
				SnowFlake.gameObject.SetActive(false);
				Easteregg.gameObject.SetActive(true);

			}
		}
		else
		{
			Pumpkin.gameObject.SetActive(false);
			Spike.gameObject.SetActive(true);
			SnowFlake.gameObject.SetActive(false);
			Easteregg.gameObject.SetActive(false);
		}
	}

	void DisableOtherSkins() // Put the other events bool here
	{
		Halloween = false;
		Christmas = false;
		Easter = false; 
	}



}
