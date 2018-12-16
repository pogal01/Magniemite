using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Player_Start : MonoBehaviour
{




	public GameObject Player;
	public GameObject Original;
	public GameObject Cute;
	public GameObject Dragniemite;
	public GameObject Magnieling;
	public GameObject Start_pos;
	public GameObject DeathScreen;
	//Called objects
	private GameObject Spike1 = null;
	private GameObject EndWall = null;
	//Called objects end
	public bool DeathScoreSet;
	public bool ReviveScreen = false;
	public bool ADError = false;
	public bool Skiped = false;
	public int Char;
	public bool test;
	public bool CanBeRevived = true;
	public bool InternetConnecton = false;
	public bool Revived = false;
	public bool hasbeenrevived = false;
	public bool MagnieWalk = true;
	public bool BeenHit = false;
	public bool Dead = false;
	public bool Rez = false;
	public bool TriggrBackGround = false;

	// Use this for initialization


	private void Awake()
	{
		Spike1 = GameObject.Find("Spike");
		EndWall = GameObject.Find("EndWall");






	}

	void RevivescreenF()
	{

	}

	void ADErrorF()
	{

	}
	void SkipedF()
	{

	}

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



	void Start()
	{


		//Characters
		Original.gameObject.SetActive(false);
		Cute.gameObject.SetActive(false);
		Dragniemite.gameObject.SetActive(false);
		Magnieling.gameObject.SetActive(false);
		
	//Characters end


	AlimateChar();
		Player.transform.position = Start_pos.transform.position;
		
		DeathScreen.gameObject.SetActive(false);
		ReviveScreen = false;
		ADError = false;
		Skiped = false;
		CanBeRevived = true;
		Revived = false;
		hasbeenrevived = false;
		BeenHit = false;
		Dead = false;
		Rez = false;
		Character();

		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			Debug.LogError("Check internet connection!");
			InternetConnecton = false;
		}
		else
		{
			InternetConnecton = true;
		}

	}

	void AdERROR()
	{
		ADError = true;

	}

	void ENDSecondLife()
	{

		if (CanBeRevived == false)
		{
			Dead = true;
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
		Rez = true;
		HitHappend();
		Invoke("RezHappend", 1);
	}
	void RezHappend()
	{
		Rez = false;
		

	}
	void HitHappend()
	{
		BeenHit = false;
	}


	void CharacterHit()
	{
		//Spike 1
		if (GameObject.Find("Spike").GetComponent<Destroy_player>().GameOver == true)
		{
			BeenHit = true;
		}
		//Spike 2
		if (GameObject.Find("Spike2").GetComponent<Destroy_player>().GameOver == true)
		{
			BeenHit = true;
		}
		//Spike 3
		if (GameObject.Find("Spike3").GetComponent<Destroy_player>().GameOver == true)
		{
			BeenHit = true;
		}
		//Spike 4
		if (GameObject.Find("Spike4").GetComponent<Destroy_player>().GameOver == true)
		{
			BeenHit = true;
		}
		//Spike 5
		if (GameObject.Find("Spike5").GetComponent<Destroy_player>().GameOver == true)
		{
			BeenHit = true;
		}
	}



	void Update()
	{
		//start of Update
		CharacterHit();

		if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
		{

			MagnieWalk = true;

		}

		if (EndWall.GetComponent<GameOver>().End == true)
		{
			if (InternetConnecton == false)
			{
				Dead = true;
				MagnieWalk = false;
				CanBeRevived = false;
			}
			if (InternetConnecton == true)
			{

				Invoke("Revive",1);

				MagnieWalk = false;

				if (CanBeRevived == false)
				{
					ENDSecondLife();
				}
			}

		}
		if (CanBeRevived == false)
		{
			if (EndWall.GetComponent<GameOver>().End == true)
			{
				ENDSecondLife();
			}
		}
		if (Input.GetKeyDown("p"))
		{
			InternetConnecton = true;
		}

		if (EndWall.GetComponent<Eliminate_Player>().DestroyPlayer == true)
		{
			Dead = false;
			Invoke("SetDeathScore",1);
		}

		if(Rez == true)
		{
			Invoke("BackgroundTrigger", 1);
		}

		if(TriggrBackGround == true)
		{
			Invoke("BackGroundTriggerEnd", 1);
		}

		//End of Update
	}


	public void PlayerNotRevive()
	{
		CanBeRevived = false;
		Dead = true;
		Revived = false;
		ReviveScreen = false;
	}

	public void ReviveCharacter()
	{
		ShowRewardedVideo();
		ADError = false;

	}




	public void Revive()
	{
		Fullrevive();
	}

	void Fullrevive()
	{
		if (CanBeRevived == true)
		{
			ReviveScreen = true;
			hasbeenrevived = true;
		}
	}

	public void SetDeathScore()
	{

		DeathScoreSet = true;
		
	}

	void BackgroundTrigger()
	{
		TriggrBackGround = true;
	}

	void BackGroundTriggerEnd()
	{
		TriggrBackGround = false;
	}


}
