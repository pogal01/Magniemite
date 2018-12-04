using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{
	public bool Hit;
	public float Velocity = -10f;
	

	// Use this for initialization
	void Start()
	{
		Hit = false;
		
	}

	// Update is called once per frame
	




	void FixedUpdate()
	{
		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Dead == true)
		{ 
					//Input characters that don't need a pully puffer here
			if(GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Char == 0)
			transform.Translate(Velocity * Time.deltaTime, 0, 0);

			if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Char == 1)
				transform.Translate(Velocity * Time.deltaTime, 0, 0);


			

			//

		}

		if (GameObject.Find("EndWall").GetComponent<Eliminate_Player>().DestroyPlayer == true)
		{
			//Debug.Log("Destroyed the player");
			
		}
		

	}


	void OnTriggerEnter2D(Collider2D other)
	//When a trigger has been enterd
	{

		if (other.tag == "Spike")// Player touched spike
		{
			Hit = true;
			Invoke("StopHit",1);
			//		Debug.Log("hit");
			FindObjectOfType<AudioMannager>().Play("MagniemiteHurt");

		}

	}
	void StopHit()
	{
		Hit = false;
	}


}
