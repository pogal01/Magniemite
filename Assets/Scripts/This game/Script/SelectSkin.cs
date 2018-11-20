using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSkin : MonoBehaviour {

	public void SkinSelect()
	{
		SceneManager.LoadScene("PickASKin");
	}
	//
	public void Back()
	{
		SceneManager.LoadScene("Start");
	}

	

	//PlayerPrefs.SetInt("HHighscore", score);
}
