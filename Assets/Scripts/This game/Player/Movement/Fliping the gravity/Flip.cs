using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
	



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
				Debug.Log("Fliped");
				SpriteRen.flipY = true;
			}

			else
			{

				Physics2D.gravity = new Vector2(0, -9.8f);
				Debug.Log("Normal");
				SpriteRen.flipY = false;
				
			}


		}
	}


	//Fixed update

	void Update()
	{

		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 0)
		{
			if (GameObject.Find("Magneimite").GetComponent<Flip>().Activite == true)
			{

				FlipScript();

			}
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 1)
		{
			if (GameObject.Find("Cute").GetComponent<Flip>().Activite == true)
			{

				FlipScript();

			}
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 2)
		{
			if (GameObject.Find("Dragniemite").GetComponent<Flip>().Activite == true)
			{

				FlipScript();

			}
		}

		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 3)
		{
			if (GameObject.Find("Magnieling").GetComponent<Flip>().Activite == true)
			{

				FlipScript();

			}
		}



		if (GameObject.Find("EndWall").GetComponent<GameOver>().End == true)
		{
			Activite = false;
		}

		if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().Reseting == true)
		{
			Activite = true;
		}

	}
}



