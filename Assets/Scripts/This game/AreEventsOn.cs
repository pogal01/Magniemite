using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreEventsOn : MonoBehaviour
{

	public bool EStatus;    //Events on or off 0 = off 1 = on


	// Use this for initialization
	void Start ()
	{
		
	}

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		Debug.Log("Awake:" + this.gameObject);

	}


	// Update is called once per frame
	void Update()
	{
		if (GameObject.Find("InvisablePufferfish6").GetComponent<WhichSceneIsthis>().Scene == 7)
		{
			if (GameObject.Find("SmartPuffer").GetComponent<EventBool>().EventsOn == true)
			{
				EStatus = true;

			}
			if (GameObject.Find("SmartPuffer").GetComponent<EventBool>().EventsOn == false)
			{
				EStatus = false;

			}


		}

	}
}
