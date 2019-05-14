using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFall : MonoBehaviour {

	public Rigidbody2D Ridge;
	private GameObject Hat;
	public GameObject PlayerGO;
	public GameObject HHatPos;
	public GameObject CHatPos;
	public GameObject EHatPos;
	public GameObject HatHolder;
	public GameObject HatHolderPos;
	public string PlayerS;


	

	private GameObject EventPuffer;
	private GameObject InvisPuffer5;


	private GameObject Drage_HHat;
	private GameObject Drage_CHat;
	private GameObject Drage_EHat;
	private GameObject Magnieling_HHat;
	private GameObject Magnieling_CHat;
	private GameObject Magnieling_EHat;


	private void Awake()
	{
	 EventPuffer = GameObject.Find("EventPuffer");
	 InvisPuffer5 = GameObject.Find("InvisablePufferfish5");

     Drage_HHat = GameObject.Find("Dragniemite_HalloweenHat");
	 Drage_CHat = GameObject.Find("Dragniemite_ChristmasHat");
	 Drage_EHat = GameObject.Find("Dragniemite_EasterHat");
	 Magnieling_HHat = GameObject.Find("Magnieling_HalloweenHat");
	 Magnieling_CHat = GameObject.Find("Magnieling_ChristmasHat");
     Magnieling_EHat = GameObject.Find("Magnieling_EasterHat");

	}
	// Use this for initialization
	void Start ()
	{
		Ridge = GetComponent<Rigidbody2D>();
		Invoke("Hatpos", 2);
		Drage_HHat.gameObject.SetActive(false);
		Drage_CHat.gameObject.SetActive(false);
		Drage_EHat.gameObject.SetActive(false);
		Magnieling_HHat.gameObject.SetActive(false);
		Magnieling_CHat.gameObject.SetActive(false);
		Magnieling_EHat.gameObject.SetActive(false);
	}
	

	
	void Hatpos()
	{
		
		if (EventPuffer.GetComponent<Events>().Halloween == true)
		{
			HHatPos.transform.position = Hat.transform.position;
		}
		if (EventPuffer.GetComponent<Events>().Christmas == true)
		{
			CHatPos.transform.position = Hat.transform.position;
		}
		if (EventPuffer.GetComponent<Events>().Easter == true)
		{
			EHatPos.transform.position = Hat.transform.position;
		}
			
	}
	


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey("l"))
		{
			Debug.Log(Hat);
		}
		if(GameObject.Find(PlayerS).GetComponent<Damaged>().Hit == true)
		{
			Ridge.simulated = true;
			HatHolder.transform.parent = null;
			

		}
		if (InvisPuffer5.GetComponent<Player_Start>().Rez == true)
		{
			Ridge.simulated = false;
			HatHolder.transform.parent = PlayerGO.transform;
			if (EventPuffer.GetComponent<Events>().Halloween == true)
			{
				//Halloween
				HatHolder.transform.position = HatHolderPos.transform.position;
				Hat.transform.position = HHatPos.transform.position;
				Hat.transform.rotation = HHatPos.transform.rotation;
				Debug.Log("Halloween");
			}
			else if (EventPuffer.GetComponent<Events>().Christmas == true)
			{
				//Christmas
				HatHolder.transform.position = HatHolderPos.transform.position;
				Hat.transform.position = CHatPos.transform.position;
				Hat.transform.rotation = CHatPos.transform.rotation;
				Debug.Log("Christmas");

			}
			else if (EventPuffer.GetComponent<Events>().Easter == true)
			{
				//Easter
				HatHolder.transform.position = HatHolderPos.transform.position;
				Hat.transform.position = EHatPos.transform.position;
				Hat.transform.rotation = EHatPos.transform.rotation;
				Debug.Log("Easter");
			}



		}
		 // This script is for characters who don't filp
		if (EventPuffer.GetComponent<Events>().BEvents == true)
		{
			



			if (EventPuffer.GetComponent<Events>().Halloween == true)
			{
				if(PlayerS == "Dragniemite")
				{
					Hat = Drage_HHat;
					Hat.gameObject.SetActive(true);
				}
				if (PlayerS == "Magnieling")
				{
					Hat = Magnieling_HHat;
					Hat.gameObject.SetActive(true);
				}
			}
			else if (EventPuffer.GetComponent<Events>().Christmas == true)
			{
				if (PlayerS == "Dragniemite")
				{
					Hat = Drage_CHat;
					Hat.gameObject.SetActive(true);
				}
				if(PlayerS == "Magnieling")
				{
					Hat = Magnieling_CHat;
					Hat.gameObject.SetActive(true);
				}
			}
			else if (EventPuffer.GetComponent<Events>().Easter == true)
			{

				if (PlayerS == "Dragniemite")
				{
					Hat = Drage_EHat;
					Hat.gameObject.SetActive(true);
				}
				if (PlayerS == "Magnieling")
				{
					Hat = Magnieling_EHat;
					Hat.gameObject.SetActive(true);
				}
			}
			else
			{
				Hat = null;
			}
		}
	}

}

