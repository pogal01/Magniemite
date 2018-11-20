using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBool : MonoBehaviour {


	public bool EventsOn;
	public bool Check = false;
	public GameObject Select;
	public GameObject Placement1;
	public GameObject Placement2;


	// Use this for initialization
	void Start () {
		if(GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == true)
		{
			Select.transform.position = Placement1.transform.position;
		}
		if (GameObject.Find("EventPuffer").GetComponent<Events>().BEvents == false)
		{
			Select.transform.position = Placement2.transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {

		




	}

	public void Yes()
	{
		EventsOn = true;
		Check = true;
		Invoke("StopTransmition", 1);
		Select.transform.position = Placement1.transform.position;
	}
	public void No()
	{
		EventsOn = false;
		Check = true;
		Invoke("StopTransmition", 1);
		Select.transform.position = Placement2.transform.position;
	}

	void StopTransmition()
	{
		Check = false;
	}

}
