using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoseEvents : MonoBehaviour {

	public void EventSelect()
	{
		SceneManager.LoadScene("WantEvent");
	}
	//
	public void Back()
	{
		SceneManager.LoadScene("Start");
	}

}
