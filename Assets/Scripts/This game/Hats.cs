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

	private GameObject EventPuffer;
	private GameObject InvisPuffer5;

	private void Awake()
	{
		EventPuffer = GameObject.Find("EventPuffer");
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}



	// Use this for initialization
	void Start()
	{
		if (EventPuffer.GetComponent<Events>().BEvents == true)
		{
			if (EventPuffer.GetComponent<Events>().Christmas == true)
			{
				//Christmas code here
				Christmas = true;
				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(true);

				//Put other events here
				None = false;
				Halloween = false;
				

			}
			else if (EventPuffer.GetComponent<Events>().Halloween == true)
			{
				Halloween = true;
				//Halloween stuff here


				// Other events belllow
				Christmas = false;
				None = false;
				
			}
			// Input other events here
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
			//Input other events (boolens) here 
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
		


		if (EventPuffer.GetComponent<Events>().BEvents == true )
		{
			if(Christmas == true)
			{

				None = false;
				Halloween = false;


				if (InvisPuffer5.GetComponent<Player_Start>().Char == 1)
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

				else if (InvisPuffer5.GetComponent<Player_Start>().Char == 0)
				{
					
					if (GetComponent<Flip>().FlipGrav == true)
					{
						ChristmasHatAF.gameObject.SetActive(true);
						ChristmasHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
						//Debug.Log("MagniemiteTest");
					}

					if (GetComponent<Flip>().FlipGrav == false)
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
