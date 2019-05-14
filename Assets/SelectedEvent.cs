using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedEvent : MonoBehaviour
{
	public int SelectedEventS = 0;
	public GameObject HalloweenPic;
	public GameObject ChristmasPic;
	public GameObject EasterPic;
	private GameObject EventPuffer;

	void Awake()
	{
		EventPuffer = GameObject.Find("EventPuffer");

		


	}




	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (EventPuffer.GetComponent<Events>().ChosenEvent == 1)
		{
			HalloweenPic.gameObject.SetActive(true);
			ChristmasPic.gameObject.SetActive(false);
			EasterPic.gameObject.SetActive(false);
			//Debug.Log("Event1chosen");
		}
		else if (EventPuffer.GetComponent<Events>().ChosenEvent == 2)
		{
			HalloweenPic.gameObject.SetActive(false);
			ChristmasPic.gameObject.SetActive(true);
			EasterPic.gameObject.SetActive(false);
			//Debug.Log("Event2chosen");
		}
		else if (EventPuffer.GetComponent<Events>().ChosenEvent == 3)
		{
			HalloweenPic.gameObject.SetActive(false);
			ChristmasPic.gameObject.SetActive(false);
			EasterPic.gameObject.SetActive(true);
			//Debug.Log("Event3chosen");
		}
	}

	public void Halloween()
	{
		SelectedEventS = 1;
	}
	public void Christmas()
	{
		SelectedEventS = 2;
	}
	public void Easter()
	{
		SelectedEventS = 3;
	}


}
