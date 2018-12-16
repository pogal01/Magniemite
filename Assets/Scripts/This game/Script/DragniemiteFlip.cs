using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragniemiteFlip : MonoBehaviour
{




	public bool FlipGrav;
	// Use this for initialization
	public bool Activite;

	private GameObject InvisPuffer3;
	private GameObject Endwall;
	private GameObject Spike1;

	void Start()
	{
		FlipGrav = false;
		Activite = true;
		Physics2D.gravity = new Vector2(0, -9.8f);


	}

	private void Awake()
	{
		InvisPuffer3 = GameObject.Find("InvisablePufferfish3");
		Endwall = GameObject.Find("EndWall");
		Spike1 = GameObject.Find("Spike");

	}

	void FlipScript()
	{
		if (Input.GetMouseButtonDown(0))

		{
			FlipGrav = !FlipGrav;

			if (FlipGrav)
			{
				Physics2D.gravity = new Vector2(0, 9.8f);
				//Debug.Log("Fliped");
				
			}

			else
			{

				Physics2D.gravity = new Vector2(0, -9.8f);
				//Debug.Log("Normal");
				

			}


		}
	}


	//Fixed update

	void Update()
	{

		if (InvisPuffer3.GetComponent<ChoseSkin>().CharacterPicked == 2)
		{
			if (GetComponent<DragniemiteFlip>().Activite == true)
			{

				FlipScript();

			}
		}

	

		if (Endwall.GetComponent<GameOver>().End == true)
		{
			Activite = false;
		}

		if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
		{
			Activite = true;
		}

	}
}



