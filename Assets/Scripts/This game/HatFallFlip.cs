using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFallFlip : MonoBehaviour {

	public Rigidbody2D Ridge;
	public GameObject HatHolder; //The pareted Hat object
	public GameObject HatHolderPosChristmas;
	public GameObject HatHolderPosHalloween;
	public GameObject HatHolderPosEaster;
	public GameObject ChristmasHatBF;
	public GameObject ChristmasHatAF;
	public GameObject HalloweenHatBF;
	public GameObject HalloweenHatAF;
	public GameObject EasterHatBF;
	public GameObject EasterHatAF;
	public GameObject PlayerGO;
	public GameObject CHatPosBF;
	public GameObject CHatPosAF;
	public GameObject HHatPosBF;
	public GameObject HHatPosAF;
	public GameObject EHatPosBF;
	public GameObject EHatPosAF;
	public string PlayerS;

	private GameObject EventPuffer;

	private GameObject InvisPuffer5;

	private void Awake()
	{
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
		EventPuffer = GameObject.Find("EventPuffer");
	}

	// Use this for initialization
	void Start ()
	{
		Ridge = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(GameObject.Find(PlayerS).GetComponent<Damaged>().Hit == true)
		{
			Ridge.simulated = true;
			HatHolder.transform.parent = null;

		}


		if (InvisPuffer5.GetComponent<Player_Start>().Rez == true)
		{
			FixHat();
		}


	}



	void FixHat()
	{
		Ridge.simulated = false;
		HatHolder.transform.parent = PlayerGO.transform;
		if(EventPuffer.GetComponent<Events>().Christmas == true)
		{ 
			HatHolder.transform.position = HatHolderPosChristmas.transform.position;
			Debug.Log("Christmas");
			//Christmas
			ChristmasHatBF.transform.position = CHatPosBF.transform.position;
			ChristmasHatBF.transform.rotation = CHatPosBF.transform.rotation;
			ChristmasHatAF.transform.position = CHatPosAF.transform.position;
			ChristmasHatAF.transform.rotation = CHatPosAF.transform.rotation;
		}
		else if (EventPuffer.GetComponent<Events>().Halloween == true)
		{
			HatHolder.transform.position = HatHolderPosHalloween.transform.position;
			Debug.Log("Halloween");
			//Halloween
			HalloweenHatBF.transform.position = HHatPosBF.transform.position;
			HalloweenHatBF.transform.rotation = HHatPosBF.transform.rotation;
			HalloweenHatAF.transform.position = HHatPosAF.transform.position;
			HalloweenHatAF.transform.rotation = HHatPosAF.transform.rotation;
		}
		else if (EventPuffer.GetComponent<Events>().Easter == true)
		{
			//Easter
			HatHolder.transform.position = HatHolderPosEaster.transform.position;
			Debug.Log("Easter");
			EasterHatBF.transform.position = EHatPosBF.transform.position;
			EasterHatBF.transform.rotation = EHatPosBF.transform.rotation;
			EasterHatAF.transform.position = EHatPosAF.transform.position;
			EasterHatAF.transform.rotation = EHatPosAF.transform.rotation;
		}
	
		
		
		

	}	



}

	