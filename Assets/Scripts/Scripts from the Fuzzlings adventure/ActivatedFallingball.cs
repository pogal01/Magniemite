using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatedFallingball : MonoBehaviour {
    public bool BallFall = false;
    public bool CamMove = false;
	public bool StopBallTP = false;
    public GameObject Fuzzlingbackcam;
    public Transform FuzzlingBackcamNormalPos;
    public Transform FuzzlingBackcamPos;
    [SerializeField]
    Camera camera4;




    // Use this for initialization
    void Start () {
        BallFall = false;
        camera4.GetComponent<Camera>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("The_Bolder").GetComponent<BallTranslate>().MoveBall)
		{
			StopBallTP = true;

		


		}
	}


    void OnTriggerEnter(Collider other)
        //When a trigger has been enterd
    {
        if (other.tag == "Player")// by the player
        {
            CamMove = true;
            BallFall = true;
            camera4.GetComponent<Camera>().enabled = true;
			
			
			



			

		}

		
	}

    void OnTriggerExit(Collider other)
    //When a trigger has been exited by the player
    {
        if (other.tag == "Player")// by the player
        {
            CamMove = false;
			BallFall = false;


		}


    }


}
