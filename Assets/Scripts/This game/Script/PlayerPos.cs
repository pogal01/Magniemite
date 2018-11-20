using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour {
	public GameObject Player;
	public GameObject Start_pos;


	// Use this for initialization
	void Start () {

		Player.transform.position = Start_pos.transform.position;

	}

	
}
