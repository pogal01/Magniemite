﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFall : MonoBehaviour {

	public Rigidbody2D Ridge;
	public GameObject Hat;
	public GameObject PlayerGO;
	public GameObject HatPos;
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
			Hat.transform.parent = null;

		}
		if (GameObject.Find("InvisablePufferfish5").GetComponent<Revived>().Reserect == true)
		{
			Ridge.simulated = false;
			Hat.transform.parent = PlayerGO.transform;
			Hat.transform.position = HatPos.transform.position;
			Hat.transform.rotation = HatPos.transform.rotation;

		}


	}
}
