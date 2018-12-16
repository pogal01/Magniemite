using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullPlayer : MonoBehaviour {
	public GameObject Player;
	public GameObject This;
	public float Velocity = -10f;

	private GameObject InvisPuffer5;


	private void Awake()
	{
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}


	// Use this for initialization

	void Start () {
		This.transform.position = Player.transform.position;
	}
	



	// Update is called once per frame
	void FixedUpdate()
	{
		
		if (InvisPuffer5.GetComponent<Player_Start>().Dead == true)
		{
		transform.Translate(Velocity * Time.deltaTime, 0, 0);
		}

		
		
		

	}
}
