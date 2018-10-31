using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTranslate : MonoBehaviour {

	[SerializeField] private Transform Ball;
	[SerializeField] private Transform start;
	[SerializeField] private Transform fall;
	public bool MoveBall = false;
	public bool BallCanFall = false;
	


	// Use this for initialization
	void Start () {
		Ball.transform.position = start.transform.position;
		BallCanFall = true;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyUp("p"))
		{
			Ball.transform.position = fall.transform.position;
		}


		if (GameObject.Find("Lava (1)").GetComponent<Respawning>().respawn )
		{
			Ball.transform.position = start.transform.position;


		}

		if (GameObject.Find("BottemOfRampForBallFall").GetComponent<ActivatedFallingball>().BallFall)
		{

			MoveBall = true;
			
			


		}

	



		if (MoveBall == true && BallCanFall == true)
		{
			Ball.transform.position = fall.transform.position;

			if (GameObject.Find("BottemOfRampForBallFall").GetComponent<ActivatedFallingball>().StopBallTP)
			{

				MoveBall = false;


			}
			BallCanFall = false;

		}
		
	



	}

	



}
