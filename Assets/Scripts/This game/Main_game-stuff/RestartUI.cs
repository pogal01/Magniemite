using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartUI : MonoBehaviour
{

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
	}

	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Quit Game");
	}
	public void Back()
	{
		Debug.Log("Back");
		SceneManager.LoadScene("Start");
	}
	void Update()
	{
		if (GameObject.Find("EndWall").GetComponent<GameOver>().End == true)
		{
			if (Input.GetKeyDown(KeyCode.KeypadEnter))

			{
				RestartGame();
			}

			
		}
	}

}
