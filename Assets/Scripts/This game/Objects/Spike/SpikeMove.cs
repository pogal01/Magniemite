using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour {
	public float Velocity;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameObject.Find("EndWall").GetComponent<GameOver>().Stop == false)
		{
			transform.Translate(Velocity * Time.deltaTime, 0, 0);
		}
	}
}
