using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFall : MonoBehaviour {

	public Rigidbody2D Ridge;
	public GameObject Hat;
	public GameObject PlayerGO;
	public GameObject HatPos;
	public GameObject HatHolder;
	public GameObject HatHolderPos;
	public string PlayerS;

	// Use this for initialization
	void Start ()
	{
		Ridge = GetComponent<Rigidbody2D>();
		HatPos.transform.position = Hat.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(GameObject.Find(PlayerS).GetComponent<Damaged>().Hit == true)
		{
			Ridge.simulated = true;
			HatHolder.transform.parent = null;
			

		}
		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Rez == true)
		{
			Ridge.simulated = false;
			HatHolder.transform.parent = PlayerGO.transform;
			HatHolder.transform.position = HatHolderPos.transform.position;
			Hat.transform.position = HatPos.transform.position;
			Hat.transform.rotation = HatPos.transform.rotation;

		}


	}
}
