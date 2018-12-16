using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class WhichSceneIsthis : MonoBehaviour {


	public int Scene;
	public string Beining, Char, StartS, Difficult, Main, Hard, WantEvent,OtherMenue;
	Scene M_Scene;

	// Use this for initialization
	void Start () {
		Scene = 1;
	}
	
	// Update is called once per frame
	void Update () {

		M_Scene = SceneManager.GetActiveScene();

		if (M_Scene.name == Beining)
		{
			Scene = 1;
		}
		if (M_Scene.name == Char)
		{
			Scene = 2;
		}
		if (M_Scene.name == StartS) //S = screen
		{
			Scene = 3;
		}
		if (M_Scene.name == Difficult)
		{
			Scene = 4;
		}
		if (M_Scene.name == Main)
		{
			Scene = 5;
		}
		if (M_Scene.name == Hard)
		{
			Scene = 6;
		}
		if (M_Scene.name == WantEvent)
		{
			Scene = 7;
		}
		if (M_Scene.name == OtherMenue)
		{
			Scene = 8;
		}
		//InvisablePufferfish6


	}


	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		Debug.Log("Awake:" + this.gameObject);

	}



}
