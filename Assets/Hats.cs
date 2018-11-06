using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hats : MonoBehaviour {

	public bool None;
	public bool Halloween;   // Add other events here
	public bool Christmas;
	public GameObject ChristmasHatBF;
	public GameObject ChristmasHatAF;



	// Use this for initialization
	void Start()
	{
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Christmas == true)
			{
				Christmas = true;
				None = false;
				Halloween = false;

				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(true);

			}
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Halloween == true)
			{
				Christmas = false;
				None = false;
				Halloween = true;
			}
		}
	}
	// Update is called once per frame
	void Update ()
	{
		if(None == true)
		{
			Halloween = false;
			Christmas = false;
		}

		if (Halloween == true)
		{
			None = false;
			Christmas = false;
		}

		if(Christmas == false)
		{
			ChristmasHatAF.gameObject.SetActive(false);
			ChristmasHatBF.gameObject.SetActive(false);
		}


		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true )
		{
			if(Christmas == true)
			{

				None = false;
				Halloween = false;

				if (GameObject.Find("Magneimite").GetComponent<Flip>().FlipGrav == true)
				{ 
				ChristmasHatAF.gameObject.SetActive(true);
				ChristmasHatBF.gameObject.SetActive(false);
					Debug.Log("Flipped");
				}

				if (GameObject.Find("Magneimite").GetComponent<Flip>().FlipGrav == false)
				{
				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(true);
					Debug.Log("NotFlipped");
				}
			}
			
			if (Halloween == true)
			{
				//Insert Halloween accessory here
				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(false);
			}
			
		}
		else
		{
			None = true;
		}
	}
}
