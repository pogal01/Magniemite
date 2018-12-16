using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealFlip : MonoBehaviour
{
	public Collider2D AF; // After flip
	public Collider2D BF; //Before flip
	public Collider2D TopAF; // After flip
	public Collider2D TopBF; //Before flip

	private GameObject Endwall;
	private GameObject Spike1;


	public bool FlipGrav;
	SpriteRenderer SpriteRen;
	// Use this for initialization
	public bool Activite;




	private void Awake()
	{
		Endwall = GameObject.Find("EndWall");
		Spike1 = GameObject.Find("Spike");
	}

	void Start()
	{
		FlipGrav = false;
		SpriteRen = GetComponent<SpriteRenderer>();
		Activite = true;
		Physics2D.gravity = new Vector2(0, -9.8f);
		//Top and bottem Collsion
		//Collision
		AF.enabled = false;
		BF.enabled = true;

	}



	void FlipScript()
	{
		if(Activite == true)
		{ 
			if (Input.GetMouseButtonDown(0))

			{
				FlipGrav = !FlipGrav;
			
				if (FlipGrav)
				{
				Physics2D.gravity = new Vector2(0, 9.8f);
				//Debug.Log("Fliped");
				SpriteRen.flipY = true;
				AF.enabled = true;
				BF.enabled = false;
				TopAF.enabled = true;
				TopBF.enabled = false;
				}

				else
				{

				Physics2D.gravity = new Vector2(0, -9.8f);
				//Debug.Log("Normal");
				SpriteRen.flipY = false;
				AF.enabled = false;
				BF.enabled = true;
				TopAF.enabled = false;
				TopBF.enabled = true;
				}

			}
		}
	}


	//Fixed update

	void Update()
	{

	
		FlipScript();
		//Debug.Log("Cute Activated");

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



