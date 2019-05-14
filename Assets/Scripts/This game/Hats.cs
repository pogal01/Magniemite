using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hats : MonoBehaviour {

	public bool None = false;
	public bool Halloween = false;   // Add other events here
	public bool Christmas = false;
	public bool Easter = false;
	public string Character;
	public GameObject ChristmasHatBF;
	public GameObject ChristmasHatAF;
	public GameObject HalloweenHatBF;
	public GameObject HalloweenHatAF;
	public GameObject EasterHatBF;
	public GameObject EasterHatAF;

	private GameObject EventPuffer;
	private GameObject InvisPuffer5;
	private GameObject TheCharacter;

	//Characters
	private GameObject Magneimite;
	private GameObject Cute;
	private GameObject Dragniemite;
	private GameObject Magnieling;




	void Awake()
	{
		EventPuffer = GameObject.Find("EventPuffer");
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
		TheCharacter = GameObject.Find(Character);

		Magneimite = GameObject.Find("Magneimite");
		Cute = GameObject.Find("Cute");
		Dragniemite = GameObject.Find("Dragniemite");
		Magnieling = GameObject.Find("Magnieling");




		if (Character == "Magneimite")
		{
			TheCharacter = Magneimite;
		}
		else if(Character == "Cute")
		{
			TheCharacter = Cute;
		}
		else if (Character == "Dragniemite")
		{
			TheCharacter = Dragniemite;
		}
		else if (Character == "Magnieling")
		{
			TheCharacter = Magnieling;
		}
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
				Easter = false;
				HalloweenHatAF.gameObject.SetActive(false);
				HalloweenHatBF.gameObject.SetActive(false);
				EasterHatAF.gameObject.SetActive(false);
				EasterHatBF.gameObject.SetActive(false);

			}
			else if (EventPuffer.GetComponent<Events>().Halloween == true)
			{
				Halloween = true;
				//Halloween stuff here
				HalloweenHatAF.gameObject.SetActive(false);
				HalloweenHatBF.gameObject.SetActive(true);


				// Other events belllow
				Easter = false;
				Christmas = false;
				None = false;
				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(false);
				EasterHatAF.gameObject.SetActive(false);
				EasterHatBF.gameObject.SetActive(false);
			}
			// Input other events here
			else if (EventPuffer.GetComponent<Events>().Easter == true)
			{
				Easter = true;
				//Easter stuff here
				EasterHatAF.gameObject.SetActive(false);
				EasterHatBF.gameObject.SetActive(true);


				// Other events belllow
				Christmas = false;
				Halloween = false;
				None = false;
				ChristmasHatAF.gameObject.SetActive(false);
				ChristmasHatBF.gameObject.SetActive(false);
				HalloweenHatAF.gameObject.SetActive(false);
				HalloweenHatBF.gameObject.SetActive(false);
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
			Easter = false;
			//Input other events (boolens) here 
		}

		if (Halloween == true)
		{
			None = false;
			Halloween = true;
			Christmas = false;
			Easter = false;

		}

		if (Christmas == true)
		{
			None = false;
			Halloween = false;
			Christmas = true;
			Easter = false;

		}

		if (Easter== true)
		{
			None = false;
			Halloween = false;
			Christmas = false;
			Easter = true;

		}


		if (Halloween == false)
		{
			HalloweenHatAF.gameObject.SetActive(false);
			HalloweenHatBF.gameObject.SetActive(false);

		}
		
		if(Easter == true)
		{
			EasterHatAF.gameObject.SetActive(false);
			EasterHatBF.gameObject.SetActive(false);

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
			if (Christmas == true)
			{

				None = false;
				Halloween = false;
				Easter = false;


				if (InvisPuffer5.GetComponent<Player_Start>().Char == 1)
				{
					//Debug.Log("Cute");
					if (TheCharacter.GetComponent<RealFlip>().FlipGrav == true)
					{
						ChristmasHatAF.gameObject.SetActive(true);
						ChristmasHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
					}
					if (TheCharacter.GetComponent<RealFlip>().FlipGrav == false)
					{
						ChristmasHatAF.gameObject.SetActive(false);
						ChristmasHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
					}


				}

				else if (InvisPuffer5.GetComponent<Player_Start>().Char == 0)
				{

					if (TheCharacter.GetComponent<Flip>().FlipGrav == true)
					{
						ChristmasHatAF.gameObject.SetActive(true);
						ChristmasHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
						//Debug.Log("MagniemiteTest");
					}

					if (TheCharacter.GetComponent<Flip>().FlipGrav == false)
					{
						ChristmasHatAF.gameObject.SetActive(false);
						ChristmasHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
						//Debug.Log("MagniemiteTest");
					}


				}
			}
			else if (Halloween == true)
			{

				None = false;
				Halloween = true;
				Christmas = false;
				Easter = false;


				if (InvisPuffer5.GetComponent<Player_Start>().Char == 1)
				{
					//Debug.Log("Cute");
					if (TheCharacter.GetComponent<RealFlip>().FlipGrav == true)
					{
						HalloweenHatAF.gameObject.SetActive(true);
						HalloweenHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
					}
					else if (TheCharacter.GetComponent<RealFlip>().FlipGrav == false)
					{
						HalloweenHatAF.gameObject.SetActive(false);
						HalloweenHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
					}


				}

				else if (InvisPuffer5.GetComponent<Player_Start>().Char == 0)
				{

					if (TheCharacter.GetComponent<Flip>().FlipGrav == true)
					{
						HalloweenHatAF.gameObject.SetActive(true);
						HalloweenHatBF.gameObject.SetActive(false);
						Debug.Log("Flipped");
						//Debug.Log("MagniemiteTest");
					}


					else if (TheCharacter.GetComponent<Flip>().FlipGrav == false)
					{

						HalloweenHatAF.gameObject.SetActive(false);
						HalloweenHatBF.gameObject.SetActive(true);
						Debug.Log("NotFlipped");
						//Debug.Log("MagniemiteTest");
					}

				}
			







			}
			else if (Easter == true)
			{

				None = false;
				Halloween = false;
				Christmas = false;
				Easter = true;


				if (InvisPuffer5.GetComponent<Player_Start>().Char == 1)
				{
					//Debug.Log("Cute");
					if (TheCharacter.GetComponent<RealFlip>().FlipGrav == true)
					{
						EasterHatAF.gameObject.SetActive(true);
						EasterHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
					}
					else if (TheCharacter.GetComponent<RealFlip>().FlipGrav == false)
					{
						EasterHatAF.gameObject.SetActive(false);
						EasterHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
					}


				}

				else if (InvisPuffer5.GetComponent<Player_Start>().Char == 0)
				{

					if (TheCharacter.GetComponent<Flip>().FlipGrav == true)
					{
						EasterHatAF.gameObject.SetActive(true);
						EasterHatBF.gameObject.SetActive(false);
						//Debug.Log("Flipped");
						//Debug.Log("MagniemiteTest");
					}


					else if (TheCharacter.GetComponent<Flip>().FlipGrav == false)
					{

						EasterHatAF.gameObject.SetActive(false);
						EasterHatBF.gameObject.SetActive(true);
						//Debug.Log("NotFlipped");
						//Debug.Log("MagniemiteTest");
					}

				}








			}





		}
		
	}
}
