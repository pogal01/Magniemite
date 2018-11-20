using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearConsole : MonoBehaviour {

	
	void Clear()
	{
		Debug.ClearDeveloperConsole();
	}

	// Use this for initialization
	void Start () {
		Invoke("Clear", 1);
		Debug.Log("Console Cleard ");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
