using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Accept : MonoBehaviour {

	public void Next()
	{
		SceneManager.LoadScene("Start");
		
	}
	public void AcceptB()
	{
		Invoke("Next", 1);
	}
}
