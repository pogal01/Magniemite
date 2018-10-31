using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveToNextScene : MonoBehaviour {
	public bool Menue = false;


	void SwitchToNextScene()
	{
		SceneManager.LoadScene("PickASkin");
		
	}


	// Use this for initialization
	void Start () {
		Invoke("SwitchToNextScene",2);
		Menue = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
