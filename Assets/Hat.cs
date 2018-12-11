using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour {

	public bool None;
	public bool Halloween;   // Add other events here
	public bool Christmas;
	public GameObject ChristmasHat;
	//Add more hats here
	// Use this for initialization
	void Start()
	{
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Christmas == true)
			{
				Christmas = true;
			}
		}

		if(Christmas == true)
		{
			ChristmasHat.gameObject.SetActive(true);

		}
		else
		{
			ChristmasHat.gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
