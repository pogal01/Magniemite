using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{

	public GameObject BackgroundN;
	public GameObject BackgroundH;
	public GameObject BackgroundC;






	// Use this for initialization

	void Start()
	{
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == false)
		{
			BackgroundN.gameObject.SetActive(true);
			BackgroundH.gameObject.SetActive(false);
			BackgroundC.gameObject.SetActive(false);
		}

		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			if (GameObject.Find("EventPuffer").GetComponent<Events>().Halloween == true)
			{
				BackgroundN.gameObject.SetActive(false);
				BackgroundH.gameObject.SetActive(true);
				BackgroundC.gameObject.SetActive(false);
			}
			else if (GameObject.Find("EventPuffer").GetComponent<Events>().Christmas == true)
			{
				BackgroundN.gameObject.SetActive(false);
				BackgroundH.gameObject.SetActive(false);
				BackgroundC.gameObject.SetActive(true);
			}
			else
			{
				BackgroundN.gameObject.SetActive(true);
				BackgroundH.gameObject.SetActive(false);
				BackgroundC.gameObject.SetActive(false);
			}
		}
	}	
	
}
