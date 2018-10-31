using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminate_Player : MonoBehaviour {
	public bool DestroyPlayer = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			EliminatePlayer();
		}
	}


	void EliminatePlayer()
	{
		DestroyPlayer = true;
		Debug.Log("Eliminated");
	}

}
