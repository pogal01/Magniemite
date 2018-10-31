using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	GameObject[] SpikeSpawnPos;
	GameObject Currentposition;
	public GameObject Thing;

	int index;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D()
	{

		SpikeSpawnPos = GameObject.FindGameObjectsWithTag("SpikeSpawn");
		index = Random.Range(0, SpikeSpawnPos.Length);
		Currentposition = SpikeSpawnPos[index];
		print(Currentposition.name);
		Thing.transform.position = Currentposition.transform.position;
		Debug.Log("destroyed");

	}
}
