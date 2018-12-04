using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hats : MonoBehaviour {

	public bool None = false;
	public bool Halloween = false;   // Add other events here
	public bool Christmas = false;
	public string Character;
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
			else if (GameObject.Find("EventPuffer").GetComponent<Events>().Halloween == true)
			{
				Christmas = false;
				None = false;
				Halloween = true;
			}
			else
			{
				None = true;
			}
		}
		else
		{
			None = true;
		}

		if (None == true)
		{
			Halloween = false;
			Christmas = false;
		}

		if (Halloween == true)
		{
			None = false;
			Christmas = false;
		}

		if (Christmas == false)
		{
			ChristmasHatAF.gameObject.SetActive(false);
			ChristmasHatBF.gameObject.SetActive(false);
		}


	}
	// Update is called once per frame
	void Update ()
	{
		


		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true )
		{
			if(Christmas == true)
			{

				None = false;
				Halloween = false;


				if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Char == 1)
				{
					//Debug.Log("Cute");
					if (GameObject.Find(Character).GetComponent<RealFlip>().FlipGrav == true)
					{
						ChristmasHatAF.gameObject.SetActive(true);
						ChristmasHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
					}
					if (GameObject.Find(Character).GetComponent<RealFlip>().FlipGrav == false)
					{
						ChristmasHatAF.gameObject.SetActive(false);
						ChristmasHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
					}


				}

				else if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Char == 0)
				{
					
					if (GameObject.Find(Character).GetComponent<Flip>().FlipGrav == true)
					{
						ChristmasHatAF.gameObject.SetActive(true);
						ChristmasHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
						//Debug.Log("MagniemiteTest");
					}

					if (GameObject.Find(Character).GetComponent<Flip>().FlipGrav == false)
					{
						ChristmasHatAF.gameObject.SetActive(false);
						ChristmasHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
						//Debug.Log("MagniemiteTest");
					}


				}




			}

			
		}
			if (Halloween == true)
			{
				//Insert Halloween accessory here
				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(false);
			}
		
	}
}
