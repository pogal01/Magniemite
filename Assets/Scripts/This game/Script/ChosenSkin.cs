using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosenSkin : MonoBehaviour {

	public int CharacterPicked= 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("InvisiblePufferfish3").GetComponent<ChoseSkin>().PickOriginal == true)
		{
			PlayerPrefs.SetInt("CharacterPicked", 1);


		}
		if (GameObject.Find("InvisiblePufferfish3").GetComponent<ChoseSkin>().PickCute == true)
		{
			PlayerPrefs.SetInt("CharacterPicked", 2);


		}
		if (GameObject.Find("InvisiblePufferfish3").GetComponent<ChoseSkin>().Dragnie == true)
		{
			PlayerPrefs.SetInt("CharacterPicked", 3);


		}
		if (GameObject.Find("InvisiblePufferfish3").GetComponent<ChoseSkin>().Magling == true)
		{
			PlayerPrefs.SetInt("CharacterPicked", 4);


		}
	}
}
