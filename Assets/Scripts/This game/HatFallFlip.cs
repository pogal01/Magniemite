using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFallFlip : MonoBehaviour {

	public Rigidbody2D Ridge;
	public GameObject HatHolder;
	public GameObject HatHolderPos;
	public GameObject HatBF;
	public GameObject HatAF;
	public GameObject PlayerGO;
	public GameObject HatPosBF;
	public GameObject HatPosAF;
	public string PlayerS;

	private GameObject InvisPuffer5;

	private void Awake()
	{
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
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
		HatHolder.transform.position = HatHolderPos.transform.position;
		HatBF.transform.position = HatPosBF.transform.position;
		HatBF.transform.rotation = HatPosBF.transform.rotation;
		HatAF.transform.position = HatPosAF.transform.position;
		HatAF.transform.rotation = HatPosAF.transform.rotation;
	}



}

	