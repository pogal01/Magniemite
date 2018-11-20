using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {

	public int PickEvent;
	public int ActiveEvent;
	public bool Halloween = false;
	public bool Christmas = false;
	//public bool EChristmas;
	//public bool Easter;
	public bool BEvents;
	//public bool Activate;

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		Debug.Log("Awake:" + this.gameObject);

	}



	// Use this for initialization
	void Start () {
		ActiveEvent = PlayerPrefs.GetInt("Event", 1);
		PickEvent = PlayerPrefs.GetInt("Event", 1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(PickEvent == 1)
		{
			BEvents = true;
		}
		else
		{
			BEvents = false;
		}



		if (GameObject.Find("InvisablePufferfish6").GetComponent<WhichSceneIsthis>().Scene == 7)
		{
			if (GameObject.Find("SmartPuffer").GetComponent<EventBool>().Check == true)
			{
				if (GameObject.Find("EventPuffer").GetComponent<AreEventsOn>().EStatus == true)
				{
					PickEvent = 1;
					Invoke("SaveEvent", 1);
					//Activate = true;
				}

				if (GameObject.Find("EventPuffer").GetComponent<AreEventsOn>().EStatus == false)
				{
					PickEvent = 0;
					Invoke("SaveEvent", 1);
					//Activate = true;
				}
			}
		}
	}
	// How the event is saved
	public void SaveEvent()
	{
		//Invoke("CheckEvent", 1);
		PlayerPrefs.SetInt("Event", PickEvent);
		ActiveEvent = PlayerPrefs.GetInt("Event", 0);
	}

	public void EventBool()
	{
		if (GameObject.Find("SmartPuffer").GetComponent<EventBool>().Check == true)
		{
		 
			if (GameObject.Find("EventPuffer").GetComponent<AreEventsOn>().EStatus == true)
			{
				PickEvent = 1;
				Invoke("SaveEvent", 1);
				//Activate = true;
			}

			if (GameObject.Find("EventPuffer").GetComponent<AreEventsOn>().EStatus == false)
			{
				PickEvent = 0;
				Invoke("SaveEvent", 1);
				//Activate = true;
			}
		}
	}

	void Stop()
	{
		//Activate = false;
	}


	/*
	public void CheckEvent()
	{
		if(ActiveEvent == 0)
		{
			Normal();
		}
		if (ActiveEvent == 1)
		{
			Halloween();
		}
		if (ActiveEvent == 2)
		{
			Christmas();
		}
		if (ActiveEvent == 3)
		{
			Easter(); 
		}
	}
	*/
	/*
	//Event functions go here.
	void Normal()
	{
		PickEvent = 0;
	}
	 
	void Halloween()
	{
		PickEvent = 1;
	}

	void Christmas()
	{
		PickEvent = 2;
	}

	void Easter()
	{
		PickEvent = 3;
	}
	//

	*/


}
