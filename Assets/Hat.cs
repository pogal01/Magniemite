using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour
{

	public bool None;
	public bool Halloween;   // Add other events here
	public bool Christmas;
	public bool Easter;
	public GameObject ChristmasH;
	public GameObject HalloweenH;
	public GameObject EasterH;
	//Add more hats here
	// Use this for initialization
	void Awake()
	{
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Halloween == true)
			{
				Halloween = true;
				Christmas = false;
				Easter = false;
				None = false;

			}
			else if(GameObject.Find("EventPuffer").GetComponent<Events>().Christmas == true)
			{
				Halloween = false;
				Christmas = true;
				Easter = false;
				None = false;
			}
			else if (GameObject.Find("EventPuffer").GetComponent<Events>().Easter == true)
			{
				Halloween = false;
				Christmas = false;                                                                                                                             
				Easter = true;
				None = false;
			}
			else
			{
				Halloween = false;
				Christmas = false;
				Easter = false;
				None = true;
			}

		}
		else
		{
			None = true;
		}
		
	}

	void Refresh()
	{
		if (Input.GetKey("k"))
		{
			Invoke("GiveHat", 1);
		}
	}


	void GiveHat()
	{
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			//Add more hats here
			if (Halloween == true)
			{
				None = false;
				HalloweenH.gameObject.SetActive(true);
				ChristmasH.gameObject.SetActive(false);
				EasterH.gameObject.SetActive(false);
				Debug.Log("Halloween Hats");
			}
			if (Christmas == true)
			{
				None = false;
				HalloweenH.gameObject.SetActive(false);
				ChristmasH.gameObject.SetActive(true);
				EasterH.gameObject.SetActive(false);
				Debug.Log("Christmas Hats");
			}
			if (Easter == true)
			{
				None = false;
				HalloweenH.gameObject.SetActive(false);
				ChristmasH.gameObject.SetActive(false);
				EasterH.gameObject.SetActive(true);
				Debug.Log("Easter Hats");
			}
			else
			{
				HalloweenH.gameObject.SetActive(false);
				ChristmasH.gameObject.SetActive(false);
				EasterH.gameObject.SetActive(false);
			}
		}
	}
	// Update is called once per frame
}
