using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Revived : MonoBehaviour {
	public GameObject ReviveScreen;
	public GameObject AdErrorScreen;
	public GameObject YouSkiped;
	public bool Reserect = false;



	private GameObject InvisPuffer5;


	private void Awake()
	{
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}


	// Use this for initialization
	void Start () {
		ReviveScreen.gameObject.SetActive(false);
		AdErrorScreen.gameObject.SetActive(false);
		YouSkiped.gameObject.SetActive(false);
	}
	
	void Reserecting()
	{
		Reserect = true;
		Invoke(" Reserected", 1);
	}
	void Reserected()
	{
		Reserect = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (InvisPuffer5.GetComponent<Player_Start>().ReviveScreen == true)
		{
			ReviveScreen.gameObject.SetActive(true);
		}
		else
		{
			ReviveScreen.gameObject.SetActive(false);
		}
		//
		if (InvisPuffer5.GetComponent<Player_Start>().ADError == true)
		{
			AdErrorScreen.gameObject.SetActive(false);
		}
		else
		{
			AdErrorScreen.gameObject.SetActive(false);
		}
		//
		if (InvisPuffer5.GetComponent<Player_Start>().Skiped == true)
		{
			YouSkiped.gameObject.SetActive(true);
		}
		else
		{
			YouSkiped.gameObject.SetActive(false);
		}


	}
	void AdERROR()
	{
		AdErrorScreen.gameObject.SetActive(true);

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
			Reserecting();
		}
		else if (result == ShowResult.Skipped)
		{
			Debug.LogWarning("Video was skipped No Reward will be given");
			YouSkiped.gameObject.SetActive(true);
			ReviveScreen.gameObject.SetActive(false);
			AdErrorScreen.gameObject.SetActive(false);
		}
		else if (result == ShowResult.Failed)
		{
			ReviveScreen.gameObject.SetActive(false);
			AdErrorScreen.gameObject.SetActive(true);
			Debug.LogError("Video failed to show");
			Invoke("AdERROR", 1);
		}
	}



	public void ReviveCharacter()
	{
		ShowRewardedVideo();
		AdErrorScreen.gameObject.SetActive(false);

	}



}
