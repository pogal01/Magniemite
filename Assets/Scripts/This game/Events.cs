using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {

	public int PickEvent;
	public int ActiveEvent;
	public int ChosenEvent = 0;
	public bool Halloween = false;
	public bool Christmas = false;
	public bool Easter= false;
	


	private GameObject SmartPuffer;
	private GameObject InvisablePufferfish6;
	//public bool EChristmas;

	public bool BEvents;
	//public bool Activate;

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		Debug.Log("Awake:" + this.gameObject);
		InvisablePufferfish6 = GameObject.Find("InvisablePufferfish6");
	}



	// Use this for initialization
	void Start () {
		ActiveEvent = PlayerPrefs.GetInt("Event", 1);
		PickEvent = PlayerPrefs.GetInt("Event", 1);
		ChosenEvent = PlayerPrefs.GetInt("Events", 1);
	}
	



	// Update is called once per frame
	void Update ()
	{
		if (InvisablePufferfish6.GetComponent<WhichSceneIsthis>().Scene == 7)
		{
			SmartPuffer = GameObject.Find("SmartPuffer");
			
			

			if (SmartPuffer.GetComponent<SelectedEvent>().SelectedEventS == 1)
			{
				ChosenEvent = 1;
				//Debug.Log("H");
			
			
			}
			else if (SmartPuffer.GetComponent<SelectedEvent>().SelectedEventS == 2)
			{
				ChosenEvent = 2;
				//Debug.Log("C");
			
			}
			else if (SmartPuffer.GetComponent<SelectedEvent>().SelectedEventS == 3)
			{
				ChosenEvent = 3;
				//Debug.Log("E");
				
			}
		}

		if (PickEvent == 1)
		{
			BEvents = true;
		}
		else
		{
			BEvents = false;
		}
		// would need a event to be added
		if (ChosenEvent == 0)
		{
			Halloween = false;
			Christmas = false;
			Easter = false;
		}
		else if (ChosenEvent == 1)
		{
			Halloween = true;
			Christmas = false;
			Easter = false;
		}
		else if (ChosenEvent == 2)
		{
			Halloween = false;
			Christmas = true;
			Easter = false;
		}
		else if (ChosenEvent == 3)
		{
			Halloween = false;
			Christmas = false;
			Easter = true;
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
