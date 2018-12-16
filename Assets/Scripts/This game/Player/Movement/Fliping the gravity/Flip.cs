using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
	private GameObject PlayerGO;
	private GameObject Endwall;
	private GameObject Spike1;




	private void Awake()
	{
		Endwall = GameObject.Find("EndWall");
		Spike1 = GameObject.Find("Spike");


	}

	public bool FlipGrav;
	SpriteRenderer SpriteRen;
	// Use this for initialization
	public bool Activite;
	void Start()
	{
		FlipGrav = false;
		SpriteRen = GetComponent<SpriteRenderer>();
		Activite = true;
		Physics2D.gravity = new Vector2(0, -9.8f);


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
				SpriteRen.flipY = true;
			}

			else
			{

				Physics2D.gravity = new Vector2(0, -9.8f);
				//Debug.Log("Normal");
				SpriteRen.flipY = false;
				
			}


		}
	}


	//Fixed update

	void Update()
	{

	
		if (GetComponent<Flip>().Activite == true)
		{
			FlipScript();
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



