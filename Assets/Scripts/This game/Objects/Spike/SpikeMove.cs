using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour {
	public float Velocity;

	private GameObject Endwall;
	
	private void Awake()
	{
		Endwall = GameObject.Find("EndWall");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Endwall.GetComponent<GameOver>().Stop == false)
		{
			transform.Translate(Velocity * Time.deltaTime, 0, 0);
		}
	}
}
