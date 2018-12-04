using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFallFlip : MonoBehaviour {

	public Rigidbody2D Ridge;
	public GameObject HatHolder;
	public GameObject HatBF;
	public GameObject HatAF;
	public GameObject PlayerGO;
	public GameObject HatPosBF;
	public GameObject HatPosAF;
	public string PlayerS;

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
			HatBF.transform.parent = null;
			HatAF.transform.parent = null;

		}
		if (GameObject.Find("InvisablePufferfish5").GetComponent<Revived>().Reserect == true)
		{
			Ridge.simulated = false;
			HatHolder.transform.parent = PlayerGO.transform;
			HatBF.transform.position = HatPosBF.transform.position;
			HatBF.transform.rotation = HatPosBF.transform.rotation;
			HatAF.transform.position = HatPosAF.transform.position;
			HatAF.transform.rotation = HatPosAF.transform.rotation;
		}


	}
}
