using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Player_Start_Hard : MonoBehaviour
{



	public GameObject Original;
	public GameObject Cute;
	public GameObject Dragniemite;
	public GameObject Magnieling;
	public GameObject DeathScreen;

	//Called Objects
	private GameObject InvisablePufferfish5 = null;
	private GameObject Spike1 = null;
	private GameObject Spike2 = null;
	private GameObject Spike3 = null;
	private GameObject Spike4 = null;
	private GameObject Spike5 = null;
	private GameObject EndWall = null;
	//End of called objects
	public bool ReviveScreen = false;
	public bool ADError = false;
	public bool Skiped = false;
	public int Char;
	public bool test;
	public bool CanBeRevived = true;
	public bool InternetConnecton = false;
	public bool HardMode = true;
	public bool Revived = false;
	public bool hasbeenrevived = false;
	public bool MagnieWalk = true;
	// Use this for initialization
	public Text Score;
	private int score;
	public Text ScoreOnDeath;
	public Text HHighscore;
	public Text CurrentHighScore;



	void OriginalChar()
	{
		Original.gameObject.SetActive(true);
		Char = 0;
		CharChosen();
	}

	void Cutechar()
	{
		Cute.gameObject.SetActive(true);
		Char = 1;
		CharChosen();


	}
	void Dragniemitechar()
	{
		Dragniemite.gameObject.SetActive(true);
		Char = 2;
		CharChosen();
	}

	void MagnielingChar()
	{
		Magnieling.gameObject.SetActive(true);
		Char = 3;
		CharChosen();
	}


	void CharChosen()
	{
		if (Char != 0)
		{
			Original.gameObject.SetActive(false);

		}

		if (Char != 1)
		{
			Cute.gameObject.SetActive(false);

		}
		if (Char != 2)
		{
			Dragniemite.gameObject.SetActive(false);
		}
		if (Char != 3)
		{
			Magnieling.gameObject.SetActive(false);
		}

	}

	void Character()
	{
		Debug.Log("Character function active");
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 0)
		{
			OriginalChar();
			Debug.Log("Original");
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 1)
		{
			Cutechar();
			Debug.Log("Cute");
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 2)
		{
			Dragniemitechar();
			Debug.Log("Dragniemite");
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 3)
		{
			MagnielingChar();
			Debug.Log("Magnieling");
		}
	}


	void AlimateChar()
	{

		MagnieWalk = true;


	}

	void Awake()
	{
		//Finding Gameobjects
		InvisablePufferfish5 = GameObject.Find("InvisablePufferfish5");
		Spike1 = GameObject.Find("Spike");
		Spike2 = GameObject.Find("Spike2");
		Spike3 = GameObject.Find("Spike3");
		Spike4 = GameObject.Find("Spike4");
		Spike5 = GameObject.Find("Spike5");




		EndWall = GameObject.Find("EndWall");
	}

	void Start()
	{
		//start of start

		//Music
		FindObjectOfType<AudioMannager>().Play("BackgroundMusic");
		// Music End

		//Characters
		Original.gameObject.SetActive(false);
		Cute.gameObject.SetActive(false);

		//Characters end
		AlimateChar();
		score = 0;
		SetScoreText();
		DeathScreen.gameObject.SetActive(false);
		ReviveScreen = false;
		ADError = false;
		Skiped = false;
		Dragniemite.gameObject.SetActive(false);
		HHighscore.text = PlayerPrefs.GetInt("HHighscore", 0).ToString();
		CurrentHighScore.text = PlayerPrefs.GetInt("HHighscore", 0).ToString();
		CanBeRevived = true;
		HardMode = true;
		Revived = false;
		hasbeenrevived = false;
		Character();

		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			Debug.Log("Error. Check internet connection!");
			InternetConnecton = false;
		}
		else
		{
			InternetConnecton = true;
		}
	



		//End of start
	}

	void AdERROR()
	{
		ADError = true;

	}

	void ENDSecondLife()
	{

		if (CanBeRevived == false)
		{
			SetDeathScore();
		}


	}

	void ShowRewardedVideo()
	{
		ShowOptions options = new ShowOptions();
		options.resultCallback = HandleShowResult;

		Advertisement.Show("rewardedVideo", options);
	}



	void HandleShowResult
		(ShowResult result)
	{
		if (result == ShowResult.Finished)
		{
			Debug.Log("Video completed");
			Reserect();
		}
		else if (result == ShowResult.Skipped)
		{
			Debug.LogWarning("Video was skipped No Reward will be given");
			Skiped = true;
			ReviveScreen = false;
			ADError = false;
		}
		else if (result == ShowResult.Failed)
		{
			ReviveScreen = false;
			ADError = false;
			Debug.LogError("Video failed to show");
			Invoke("AdERROR", 1);
		}
	}

	void Reserect()
	{
		CanBeRevived = false;

		MagnieWalk = true;

		ReviveScreen = false;
		Revived = true;
	}


	void Update()
	{

		if (InvisablePufferfish5.GetComponent<Player_Start>().DeathScoreSet == true)
		{
			CanBeRevived = false;
			SetDeathScore();
		}

		if (InvisablePufferfish5.GetComponent<Revived>().Reserect == true)
		{
			Reserect();
		}

		if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
		{

			MagnieWalk = true;

		}

		if (EndWall.GetComponent<GameOver>().End == true)
		{
			if (InternetConnecton == false)
			{

				SetDeathScore();
				MagnieWalk = false;
				CanBeRevived = false;
			}
			if (InternetConnecton == true)
			{

				Revive();

				MagnieWalk = false;

				if (CanBeRevived == false)
				{
					Invoke("ENDSecondLife", 1);
				}
			}

		}
		if (CanBeRevived == false)
		{
			if (EndWall.GetComponent<GameOver>().End == true)
			{
				Invoke("ENDSecondLife", 1);
			}
		}
		if (Input.GetKeyDown("p"))
		{
			InternetConnecton = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "SpikeHit")
		{
			score = score + 1;
			SetScoreText();

			/*
			// Spikes effects
			if (Spike1.GetComponent<Spawn_loc1>().loc1 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighestSpikepass");
			}
			if (Spike1.GetComponent<Spawn_loc1>().loc2 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighSpikepass");
			}
			if (Spike1.GetComponent<Spawn_loc1>().loc3 == true)
			{
				FindObjectOfType<AudioMannager>().Play("NormalSpikepass");
			}
			if (Spike1.GetComponent<Spawn_loc1>().loc4 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowSpikepass");
			}
			if (Spike1.GetComponent<Spawn_loc1>().loc5 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowestSpikepass");
			}
			*/

		}

		if (other.tag == "SpikeHit2")
		{
			score = score + 1;
			SetScoreText();

			// Spikes effects
			/*
			if (Spike2.GetComponent<Spawn_loc1>().loc1 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighestSpikepass");
			}
			if (Spike2.GetComponent<Spawn_loc1>().loc2 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighSpikepass");
			}
			if (Spike2.GetComponent<Spawn_loc1>().loc3 == true)
			{
				FindObjectOfType<AudioMannager>().Play("NormalSpikepass");
			}
			if (Spike2.GetComponent<Spawn_loc1>().loc4 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowSpikepass");
			}
			if (Spike2.GetComponent<Spawn_loc1>().loc5 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowestSpikepass");
			}
			*/
		}

		if (other.tag == "SpikeHit3")
		{
			score = score + 1;
			SetScoreText();

			/*
			// Spikes effects
			if (Spike3.GetComponent<Spawn_loc1>().loc1 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighestSpikepass");
			}
			if (Spike3.GetComponent<Spawn_loc1>().loc2 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighSpikepass");
			}
			if (Spike3.GetComponent<Spawn_loc1>().loc3 == true)
			{
				FindObjectOfType<AudioMannager>().Play("NormalSpikepass");
			}
			if (Spike3.GetComponent<Spawn_loc1>().loc4 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowSpikepass");
			}
			if (Spike3.GetComponent<Spawn_loc1>().loc5 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowestSpikepass");
			}
			*/
		}

		if (other.tag == "SpikeHit4")
		{
			score = score + 1;
			SetScoreText();

			/*
			// Spikes effects
			if (Spike4.GetComponent<Spawn_loc1>().loc1 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighestSpikepass");
			}
			if (Spike4.GetComponent<Spawn_loc1>().loc2 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighSpikepass");
			}
			if (Spike4.GetComponent<Spawn_loc1>().loc3 == true)
			{
				FindObjectOfType<AudioMannager>().Play("NormalSpikepass");
			}
			if (Spike4.GetComponent<Spawn_loc1>().loc4 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowSpikepass");
			}
			if (Spike4.GetComponent<Spawn_loc1>().loc5 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowestSpikepass");
			}
			*/
		}

		if (other.tag == "SpikeHit5")
		{
			score = score + 1;
			SetScoreText();

			/*
			// Spikes effects
			if (Spike5.GetComponent<Spawn_loc1>().loc1 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighestSpikepass");
			}
			if (Spike5.GetComponent<Spawn_loc1>().loc2 == true)
			{
				FindObjectOfType<AudioMannager>().Play("HighSpikepass");
			}
			if (Spike5.GetComponent<Spawn_loc1>().loc3 == true)
			{
				FindObjectOfType<AudioMannager>().Play("NormalSpikepass");
			}
			if (Spike5.GetComponent<Spawn_loc1>().loc4 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowSpikepass");
			}
			if (Spike5.GetComponent<Spawn_loc1>().loc5 == true)
			{
				FindObjectOfType<AudioMannager>().Play("LowestSpikepass");
			}
			*/
		}
	}

	public void PlayerNotRevive()
	{
		CanBeRevived = false;
		SetDeathScore();
	}

	public void ReviveCharacter()
	{
		ShowRewardedVideo();
		ADError = false;

	}




	public void Revive()
	{
		if (CanBeRevived == true)
		{
			ReviveScreen = true;
			hasbeenrevived = true;
		}


	}

	public void SetDeathScore()
	{


		ScoreOnDeath.text = "Score on death " + score.ToString();
		DeathScreen.gameObject.SetActive(true);


		if (score > PlayerPrefs.GetInt("HHighscore", 0))
		{
			PlayerPrefs.SetInt("HHighscore", score);
			HHighscore.text = score.ToString();
		}
		ADError = false;
		ReviveScreen = false;
		Revived = false;
	}

	public void SetScoreText()
	{
		Score.text = "Score " + score.ToString();
	}


}
