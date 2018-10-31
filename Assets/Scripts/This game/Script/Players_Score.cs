using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players_Score : MonoBehaviour {
	public Text Score;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		SetScoreText();


	}
	

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			score = score +1;
			SetScoreText();
		}
	}

	void SetScoreText()
	{
		Score.text = "Score " + score.ToString();
	}

}
